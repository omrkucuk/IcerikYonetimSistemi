using IcerikUretimSistemi.DataAccess.Context;
using IcerikUretimSistemi.Entites.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcerikUretimSistemi.DataAccess.Repositories
{
    public class FollowRepository : GenericRepository<Follow>
    {
        private readonly AppDBContext _dbContext; // Veritabanı context'i

        public FollowRepository(AppDBContext db) : base(db)
        {
            _dbContext = db;
        }

        public List<User> GetFollowedUsers(Guid currentUserId)
        {
            return _dbContext.Follows
                .Where(f => f.FollowerID == currentUserId) // Takip eden kişi currentUserId olanlar
                .Include(f => f.Following) // Takip edilen kullanıcı bilgilerini getir
                .Select(f => f.Following)  // Takip edilen kullanıcıları listeye ekle
                .ToList();
        }
    }
}
