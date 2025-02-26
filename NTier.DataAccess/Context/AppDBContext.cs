using IcerikUretimSistemi.Entites.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcerikUretimSistemi.DataAccess.Context
{
    public class AppDBContext:DbContext
    {
        public DbSet<Admin> Admin { get; set; }
        public DbSet<AdminLog> AdminLog { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Follows> Follows { get; set; }
        public DbSet<Likes> Likes { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }

}
