using FluentValidation.Results;
using IcerikUretimSistemi.Business.Abstractions;
using IcerikUretimSistemi.Business.Validators;
using IcerikUretimSistemi.DataAccess.Repositories;
using IcerikUretimSistemi.Entites.Models;
using System.Linq.Expressions;

namespace IcerikUretimSistemi.Business.Services
{
    class AdminService : IManager<Admin>
    {
        private AdminRepository _adminRepository;

        public AdminService(AdminRepository aRepo)
        {
            _adminRepository = aRepo;
        }

        public void Create(Admin entity)
        {
            AdminValidation aVal = new();
            ValidationResult result = aVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }

            _adminRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var bulunan = _adminRepository.GetByID(id);

            if (bulunan == null)
            {
                throw new Exception("Kullanıcı Bulunamadı.");
            }

            _adminRepository.Delete(id);
        }

        public IEnumerable<Admin> GetAll()
        {
            return _adminRepository.GetAll();
        }

        public Admin GetByID(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }

            return _adminRepository.GetByID(id);
        }

        public bool IfEntityExists(Expression<Func<Admin, bool>> filter)
        {
            return _adminRepository.IfEntityExists(filter);

        }

        public void Update(Admin entity)
        {
            if (entity == null)
            {
                throw new Exception("Entity null olamaz.");
            }

            _adminRepository.Update(entity);
        }
    }
}
