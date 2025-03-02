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
    public class MessageRepository : GenericRepository<Message>
    {
        private readonly AppDBContext _dbContext;
        public MessageRepository(AppDBContext db) : base(db)
        {
            _dbContext = db;
        }

    }
}
