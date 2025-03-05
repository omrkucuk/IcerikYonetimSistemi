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
    public class UserRepository : GenericRepository<User>
    {
        AppDBContext _dbContext;
        public UserRepository(AppDBContext db) : base(db)
        {
            _dbContext = db;
        }

        public bool IsFollowing(Guid followerId, Guid followingId)
        {
            using (var context = new AppDBContext())
            {
                return context.Follows.Any(f => f.FollowerID == followerId && f.FollowingID == followingId);
            }
        }

        public void Follow(Guid followerId, Guid followingId)
        {
            using (var context = new AppDBContext())
            {
                if (!context.Follows.Any(f => f.FollowerID == followerId && f.FollowingID == followingId))
                {
                    context.Follows.Add(new Follow { FollowerID = followerId, FollowingID = followingId });
                    context.SaveChanges();
                }
            }
        }

        public void Unfollow(Guid followerId, Guid followingId)
        {
            using (var context = new AppDBContext())
            {
                var followRecord = context.Follows
                    .FirstOrDefault(f => f.FollowerID == followerId && f.FollowingID == followingId);

                if (followRecord != null)
                {
                    context.Follows.Remove(followRecord);
                    context.SaveChanges();
                }
            }
        }

        public int GetFollowersCount(Guid userId)
        {
            using (var context = new AppDBContext())
            {
                return context.Follows.Count(f => f.FollowingID == userId);
            }
        }

        public int GetFollowingCount(Guid userId)
        {
            using (var context = new AppDBContext())
            {
                return context.Follows.Count(f => f.FollowerID == userId);
            }
        }
        public void RemoveFollowRelations(Guid userId)
        {
            var followEntries = _dbContext.Follows
                .Where(f => f.FollowerID == userId || f.FollowingID == userId)
                .ToList();

            _dbContext.Follows.RemoveRange(followEntries);
            _dbContext.SaveChanges();
        }

        public void RemoveComments(Guid userId)
        {
            var commentsEntries = _dbContext.Comments.Where(c => c.UserID == userId).ToList();
            _dbContext.Comments.RemoveRange(commentsEntries);
            _dbContext.SaveChanges();
        }

        public void RemoveLikes(Guid userId)
        {
            var likes = _dbContext.Likes.Where(l  => l.UserID == userId).ToList();
            _dbContext.Likes.RemoveRange(likes);
            _dbContext.SaveChanges();
        }

        public List<User> GetAllWithPosts()
        {
            return _dbContext.Users.Include(u => u.Posts).ThenInclude(p => p.Comments).ToList();
        }

    }
}
