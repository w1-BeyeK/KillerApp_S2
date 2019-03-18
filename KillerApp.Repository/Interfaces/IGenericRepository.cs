using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace KillerApp.Repository.Interfaces
{
    public interface IGenericRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetWithFilter(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);
        TEntity Insert(TEntity obj);
        TEntity Update(TEntity obj);
        void Delete(TEntity obj);
    }
}
