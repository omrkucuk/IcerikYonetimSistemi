using IcerikUretimSistemi.DataAccess.Context;
using IcerikUretimSistemi.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcerikUretimSistemi.DataAccess.Repositories
{
    public class FollowRepository : GenericRepository<Follow>
    {
        public FollowRepository(AppDBContext db) : base(db)
        {
        }
    }
}
