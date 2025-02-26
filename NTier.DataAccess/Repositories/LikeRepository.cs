using IcerikUretimSistemi.DataAccess.Context;
using IcerikUretimSistemi.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcerikUretimSistemi.DataAccess.Repositories
{
    public class LikeRepository : GenericRepository<Likes>
    {
        public LikeRepository(AppDBContext db) : base(db)
        {
        }
    }
}
