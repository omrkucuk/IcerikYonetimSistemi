using FluentValidation.Results;
using IcerikUretimSistemi.Business.Abstractions;
using IcerikUretimSistemi.Business.Validators;
using IcerikUretimSistemi.DataAccess.Context;
using IcerikUretimSistemi.DataAccess.Repositories;
using IcerikUretimSistemi.Entites.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IcerikUretimSistemi.Business.Services
{
    public class UserService : IManager<User>
    {
        private UserRepository _userRepository;

        public UserService(UserRepository uRepo)
        {
            _userRepository = uRepo;
        }


        public void Create(User entity)
        {
            UsersValidation uVal = new();
            ValidationResult result = uVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }

            _userRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var bulunan = _userRepository.GetByID(id);
            if (bulunan == null)
            {
                throw new Exception("Kullanıcı Bulunamadı.");
            }

            using (var context = new AppDBContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // Kullanıcının takip ilişkilerini kaldır
                        var follows = context.Follows
                            .Where(f => f.FollowerID == id || f.FollowingID == id)
                            .ToList();
                        context.Follows.RemoveRange(follows);

                        // Kullanıcıyı sil
                        context.Users.Remove(bulunan);

                        context.SaveChanges();
                        transaction.Commit(); // Her şey başarılıysa işlemi tamamla
                    }
                    catch (Exception)
                    {
                        transaction.Rollback(); // Hata olursa işlemi geri al
                        throw;
                    }
                }
            }

            _userRepository.Delete(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetByID(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }

            return _userRepository.GetByID(id);
        }

        public bool IfEntityExists(Expression<Func<User, bool>> filter)
        {
            return _userRepository.IfEntityExists(filter);
        }

        public void Update(User entity)
        {
            if (entity == null)
            {
                throw new Exception("Entity null olamaz.");
            }

            _userRepository.Update(entity);
        }

        public bool ToggleFollow(Guid followerId, Guid followingId)
        {
            using (var context = new AppDBContext())
            {
                var follow = context.Follows
                    .FirstOrDefault(f => f.FollowerID == followerId && f.FollowingID == followingId);

                if (follow == null)
                {
                    // Takip etme işlemi
                    var newFollow = new Follow
                    {
                        FollowerID = followerId,
                        FollowingID = followingId
                    };
                    context.Follows.Add(newFollow);
                    context.SaveChanges();
                    return true; // Takip edildi
                }
                else
                {
                    // Takibi bırakma işlemi
                    context.Follows.Remove(follow);
                    context.SaveChanges();
                    return false; // Takipten çıkıldı
                }
            }
        }
    }
}
