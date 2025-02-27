using FluentValidation.Results;
using IcerikUretimSistemi.Business.Abstractions;
using IcerikUretimSistemi.Business.Validators;
using IcerikUretimSistemi.DataAccess.Repositories;
using IcerikUretimSistemi.Entites.Models;
using System.Linq.Expressions;

namespace IcerikUretimSistemi.Business.Services
{
    public class CommentService : IManager<Comments>
    {
        private CommentsRepository _commentRepository;

        public CommentService(CommentsRepository cRepo)
        {
            _commentRepository = cRepo;
        }

        public void Create(Comments entity)
        {
            CommentsValidation cVal = new();
            ValidationResult result = cVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }

            _commentRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var bulunan = _commentRepository.GetByID(id);

            if (bulunan == null)
            {
                throw new Exception("Kullanıcı Bulunamadı.");
            }

            _commentRepository.Delete(id);
        }

        public IEnumerable<Comments> GetAll()
        {
            return _commentRepository.GetAll();
        }

        public Comments GetByID(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }

            return _commentRepository.GetByID(id);
        }

        public bool IfEntityExists(Expression<Func<Comments, bool>> filter)
        {
            return _commentRepository.IfEntityExists(filter);
        }

        public void Update(Comments entity)
        {
            if (entity == null)
            {
                throw new Exception("Entity null olamaz.");
            }

            _commentRepository.Update(entity);
        }
    }
}
