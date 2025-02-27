using IcerikUretimSistemi.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IcerikUretimSistemi.Business.Abstractions
{
    interface IManager<T> where T : class
    {
        void Create(T entity);

        void Update(T entity);

        void Delete(Guid id);

        T GetByID(Guid id);

        IEnumerable<T> GetAll();

        bool IfEntityExists(Expression<Func<T, bool>> filter);
    }
}
