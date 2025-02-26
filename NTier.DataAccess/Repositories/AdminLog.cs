using IcerikUretimSistemi.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcerikUretimSistemi.DataAccess.Repositories
{
    public class AdminLog : GenericRepository<AdminLog>
    {
        public AdminLog(AppDBContext db) : base(db)
        {
        }
    }
}
