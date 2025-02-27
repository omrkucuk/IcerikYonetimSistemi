using IcerikUretimSistemi.Business.Abstractions;
using IcerikUretimSistemi.DataAccess.Repositories;
using IcerikUretimSistemi.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IcerikUretimSistemi.Business.Services
{
    public class FollowService : IManager<Follow>
    {
        private FollowRepository _Follow;

        public FollowService(FollowRepository fRepo)
        {
            _Follow = fRepo;
        }
        public void Create(Follow entity)
        {
            _Follow.Create(entity);
        }

        public void Delete(Guid id)
        {
            var bulunan = _Follow.GetByID(id);

            if (bulunan == null)
            {
                throw new Exception("Id bilgisi boş");
            }

            _Follow.Delete(id);
        }

        public IEnumerable<Follow> GetAll()
        {
            return _Follow.GetAll();
        }

        public Follow GetByID(Guid id)
        {
            var bulunan = _Follow.GetByID(id);

            if (bulunan == null)
            {
                throw new Exception("Id bilgisi boş");
            }

           return _Follow.GetByID(id);
        }

        public bool IfEntityExists(Expression<Func<Follow, bool>> filter)
        {
            return _Follow.IfEntityExists(filter);

        }

        public void Update(Follow entity)
        {
            if (entity == null)
            {
                throw new Exception("Entity null olamaz.");
            }

            _Follow.Update(entity);
        }
    }
}
