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
    public class PostRepository : GenericRepository<Posts>
    {
        private readonly AppDBContext _context;
        public PostRepository(AppDBContext db) : base(db)
        {
            _context = db;
        }

        public List<Posts> GetPostsByUserId(Guid userId)
        {
            return _context.Posts.Where(p => p.UserID == userId).ToList();
        }

    }
}
