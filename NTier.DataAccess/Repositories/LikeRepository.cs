using IcerikUretimSistemi.DataAccess.Context;
using IcerikUretimSistemi.DataAccess.Repositories;
using IcerikUretimSistemi.Entites.Models;

public class LikeRepository : GenericRepository<Likes>
{
    private readonly AppDBContext _context;

    public LikeRepository(AppDBContext db) : base(db)
    {
        _context = db;
    }

    // ToggleLike fonksiyonu
    public bool ToggleLike(Guid postID, Guid userID)
    {
        var existingLike = _context.Likes
            .FirstOrDefault(l => l.PostID == postID && l.UserID == userID);

        if (existingLike != null)
        {
            // Eğer beğeni varsa, beğeniyi kaldırıyoruz
            _context.Likes.Remove(existingLike);
            _context.SaveChanges();
            return false; // Beğeni kaldırıldı
        }
        else
        {
            // Eğer beğeni yoksa, yeni bir beğeni ekliyoruz
            var like = new Likes
            {
                PostID = postID,
                UserID = userID,
                CreatedDate = DateTime.Now
            };
            _context.Likes.Add(like);
            _context.SaveChanges();
            return true; // Beğeni eklendi
        }
    }

    // Beğeni sayısını almak için ek bir fonksiyon
    public int GetLikeCountByPostId(Guid postID)
    {
        return _context.Likes.Count(l => l.PostID == postID);
    } 
}
