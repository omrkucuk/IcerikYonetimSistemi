using IcerikUretimSistemi.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcerikUretimSistemi.DataAccess.Repositories
{
    public class AdminLogRepository : GenericRepository<AdminLogRepository>
    {
        public AdminLogRepository(AppDBContext db) : base(db)
        {
        }
    }
}
