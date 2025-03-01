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
    }
}
