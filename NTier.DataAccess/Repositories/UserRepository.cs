using IcerikUretimSistemi.DataAccess.Context;
using IcerikUretimSistemi.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcerikUretimSistemi.DataAccess.Repositories
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository(AppDBContext db) : base(db)
        {
        }
    }
}
