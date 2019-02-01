using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OnionSample.Domain.Entity.Base;

namespace OnionSample.Domain.Interfaces.Repository.Base
{
    public interface IBaseRepository<T> : IDisposable where T : BaseEntity
    {
        IQueryable<T> All();
        IQueryable<T> All(params Expression<Func<T, Object>>[] includeProperties);
        T Find(Int64 id);
        T Find(Int64 id, params Expression<Func<T, object>>[] includeProperties);
        Task Remove(Int64 id);
        Task Insert(T model);
        Task Update(T model);
    }
}
