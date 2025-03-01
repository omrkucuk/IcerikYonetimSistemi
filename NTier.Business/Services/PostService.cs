using FluentValidation.Results;
using IcerikUretimSistemi.Business.Abstractions;
using IcerikUretimSistemi.Business.Validators;
using IcerikUretimSistemi.DataAccess.Repositories;
using IcerikUretimSistemi.Entites.Models;
using System.Linq.Expressions;

namespace IcerikUretimSistemi.Business.Services
{
    public class PostService : IManager<Posts>
    {
        private PostRepository _postRepository;

        public PostService(PostRepository pRepo)
        {
            _postRepository = pRepo;
        }


        public void Create(Posts entity)
        {
            PostValidation pVal = new();
            ValidationResult result = pVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }

            _postRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var bulunan = _postRepository.GetByID(id);

            if (bulunan == null)
            {
                throw new Exception("Kullanıcı Bulunamadı.");
            }

            _postRepository.Delete(id);
        }

        public IEnumerable<Posts> GetAll()
        {
            return _postRepository.GetAll();
        }

        public Posts GetByID(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }

            return _postRepository.GetByID(id);
        }

        public bool IfEntityExists(Expression<Func<Posts, bool>> filter)
        {
            return _postRepository.IfEntityExists(filter);
        }

        public void Update(Posts entity)
        {
            if (entity == null)
            {
                throw new Exception("Entity null olamaz.");
            }

            _postRepository.Update(entity);
        }
    }
}
