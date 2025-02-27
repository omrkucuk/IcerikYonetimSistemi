using FluentValidation.Results;
using IcerikUretimSistemi.Business.Abstractions;
using IcerikUretimSistemi.Business.Validators;
using IcerikUretimSistemi.DataAccess.Repositories;
using IcerikUretimSistemi.Entites.Models;
using System.Linq.Expressions;

namespace IcerikUretimSistemi.Business.Services
{
    class MessageService : IManager<Message>
    {
        private MessageRepository _messageRepository;

        public MessageService(MessageRepository mRepo)
        {
            _messageRepository = mRepo;
        }


        public void Create(Message entity)
        {
            MessageValidation mVal = new();
            ValidationResult result = mVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }

            _messageRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var bulunan = _messageRepository.GetByID(id);

            if (bulunan == null)
            {
                throw new Exception("Kullanıcı Bulunamadı.");
            }

            _messageRepository.Delete(id);
        }

        public IEnumerable<Message> GetAll()
        {
            return _messageRepository.GetAll();
        }

        public Message GetByID(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }

            return _messageRepository.GetByID(id);
        }

        public bool IfEntityExists(Expression<Func<Message, bool>> filter)
        {
            return _messageRepository.IfEntityExists(filter);
        }

        public void Update(Message entity)
        {
            if (entity == null)
            {
                throw new Exception("Entity null olamaz.");
            }

            _messageRepository.Update(entity);
        }
    }
}

