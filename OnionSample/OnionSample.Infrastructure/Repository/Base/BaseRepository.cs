using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OnionSample.Domain.Entity.Base;
using OnionSample.Domain.Interfaces.Repository.Base;
using OnionSample.Infrastructure.AppDataContext;

namespace OnionSample.Infrastructure.Repository.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly SimpleContext _dbContext;
        private DbSet<T> _innerDbSet;
        public BaseRepository()
        {
            _dbContext = new SimpleContext();
            _innerDbSet = _dbContext.Set<T>();

        }
        public IQueryable<T> All()
        {
            return _innerDbSet.Where(x => !x.IsDelete);
        }

        public IQueryable<T> All(params Expression<Func<T, object>>[] includeProperties)
        {
            return includeProperties == null
                ? All()
              : includeProperties.Aggregate(All(), (current, includeProperty) => current.Include(includeProperty));
        }

        public T Find(long id)
        {
            return All().FirstOrDefault(x => x.Id == id);
        }

        public T Find(long id, params Expression<Func<T, object>>[] includeProperties)
        {
            return All(includeProperties).FirstOrDefault(x => x.Id == id);
        }

        public async Task Remove(long id)
        {
            var entity = Find(id);
            _innerDbSet.Remove(entity);
            await Save();
        }

        public async Task Insert(T model)
        {
            model.AddedDate = DateTime.UtcNow;
            model.ModifiedDate = DateTime.UtcNow;
            _dbContext.Entry(model).State = EntityState.Added;
            _innerDbSet.Add(model);
            await Save();
        }

        public async Task Update(T model)
        {
            _dbContext.Entry(model).State = EntityState.Modified;
            _dbContext.Configuration.ValidateOnSaveEnabled = false;
            await Save();
            _dbContext.Configuration.ValidateOnSaveEnabled = true;
        }

        private async Task Save()
        {
           await _dbContext.SaveChangesAsync();
        }
        public void Dispose()
        {
            _innerDbSet = null;
            _dbContext.Dispose();
        }


    }
}
