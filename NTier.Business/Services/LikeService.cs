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
            var bulunanid = _likeRepository.GetByID(id);

            if (bulunanid == null)
            {
                throw new Exception("ID bilgisi boş geçilemez");
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
    }
}
