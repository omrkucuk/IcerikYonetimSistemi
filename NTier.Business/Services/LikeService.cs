using IcerikUretimSistemi.Business.Abstractions;
using IcerikUretimSistemi.DataAccess.Repositories;
using IcerikUretimSistemi.Entites.Models;
using System.Linq.Expressions;

namespace IcerikUretimSistemi.Business.Services
{
    public class LikeService : IManager<Likes>
    {
        private LikeRepository _likeRepository;

        public LikeService(LikeRepository lRepo)
        {
            _likeRepository = lRepo;
        }
        public void Create(Likes entity)
        {
            _likeRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var bulunan = _likeRepository.GetByID(id);

            if (bulunan == null)
            {
                throw new Exception("Id bilgisi boş");
            }

            _likeRepository.Delete(id);
        }

        public IEnumerable<Likes> GetAll()
        {
            return _likeRepository.GetAll();
        }

        public Likes GetByID(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }

            return _likeRepository.GetByID(id);
        }

        public bool IfEntityExists(Expression<Func<Likes, bool>> filter)
        {
            return _likeRepository.IfEntityExists(filter);
        }

        public void Update(Likes entity)
        {
            if (entity == null)
            {
                throw new Exception("Entity null olamaz.");
            }

            _likeRepository.Update(entity);
        }

        public bool ToggleLike(Guid postID, Guid userID)
        {
            return _likeRepository.ToggleLike(postID, userID);
        }

        public int GetLikeCountByPostId(Guid postID)
        {
            return _likeRepository.GetLikeCountByPostId(postID);
        }

        public bool IsPostLikedByUser(Guid postID, Guid userID)
        {
            // Veritabanı sorgusu: PostID ve UserID ile Like tablosunda arama yap
            return _likeRepository.GetAll().Any(l => l.PostID == postID && l.UserID == userID);
        }

    }
}
