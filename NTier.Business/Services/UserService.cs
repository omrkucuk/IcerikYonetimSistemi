using FluentValidation.Results;
using IcerikUretimSistemi.Business.Abstractions;
using IcerikUretimSistemi.Business.Validators;
using IcerikUretimSistemi.DataAccess.Repositories;
using IcerikUretimSistemi.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IcerikUretimSistemi.Business.Services
{
    class UserService : IManager<User>
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
    }
}
