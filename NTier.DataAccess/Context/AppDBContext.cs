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
        public DbSet<Follow> Follows { get; set; }
        public DbSet<Likes> Likes { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=MURATHAN\SQLEXPRESS01;Initial Catalog=CMS;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Follow>().Ignore(c => c.ID);

            modelBuilder.Entity<Follow>()
               .HasKey(f => new { f.FollowerID, f.FollowingID });
            // **Takip Sistemi (Follow)**
            modelBuilder.Entity<Follow>()
                .HasKey(f => new { f.FollowerID, f.FollowingID }); // Composite Primary Key

            modelBuilder.Entity<Follow>()
                .HasOne(f => f.Follower)
                .WithMany(u => u.Following)
                .HasForeignKey(f => f.FollowerID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Follow>()
                .HasOne(f => f.Following)
                .WithMany(u => u.Followers)
                .HasForeignKey(f => f.FollowingID)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Likes>().Ignore(c => c.ID);

            modelBuilder.Entity<Likes>()
                .HasKey(l => new { l.PostID, l.UserID });

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Sender)
                .WithMany()
                .HasForeignKey(m => m.SenderID)
                .OnDelete(DeleteBehavior.Restrict);  

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Receiver)
                .WithMany()
                .HasForeignKey(m => m.ReceiverID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Comments>()
                .HasOne(c => c.Post)
                .WithMany(p => p.Comments)
                .HasForeignKey(c => c.PostID)
                .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<Comments>()
                .HasOne(c => c.User)
                .WithMany(u => u.Comments)
                .HasForeignKey(c => c.UserID)
                .OnDelete(DeleteBehavior.Restrict); 

        }
    }

}
