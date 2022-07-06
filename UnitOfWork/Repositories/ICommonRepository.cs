using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.Repositories
{
    public interface ICommonRepository<T> : IDisposable where T : class
    {
        IQueryable<T> Entities();
        IEnumerable<T> GetAll();
        T FirstOrDefault(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}