using IcerikUretimSistemi.Business.Abstractions;
using IcerikUretimSistemi.DataAccess.Repositories;
using IcerikUretimSistemi.Entites.Models;
using System.Linq.Expressions;

namespace IcerikUretimSistemi.Business.Services
{
    public class AdminLogService : IManager<AdminLog>
    {
        private AdminLogRepository _adminLogRepository;

        public AdminLogService(AdminLogRepository aLogRepo)
        {
            _adminLogRepository = aLogRepo;
        }

        public void Create(AdminLog entity)
        {
            _adminLogRepository.Create(entity);

        }

        public void Delete(Guid id)
        {
            var bulunan = _adminLogRepository.GetByID(id);

            if (bulunan == null)
            {
                throw new Exception("Kullanıcı Bulunamadı.");
            }

            _adminLogRepository.Delete(id);
        }

        public IEnumerable<AdminLog> GetAll()
        {
            return _adminLogRepository.GetAll();
        }

        public AdminLog GetByID(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }

            return _adminLogRepository.GetByID(id);
        }

        public bool IfEntityExists(Expression<Func<AdminLog, bool>> filter)
        {
            return _adminLogRepository.IfEntityExists(filter);

        }

        public void Update(AdminLog entity)
        {
            if (entity == null)
            {
                throw new Exception("Entity null olamaz.");
            }

            _adminLogRepository.Update(entity);
        }
    }
}
