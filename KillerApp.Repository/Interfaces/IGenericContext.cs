using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace KillerApp.Repository.Interfaces
{
    public interface IGenericContext<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetWithFilter(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);

        TEntity FindById(TEntity obj);

        TEntity Insert(TEntity obj);
        TEntity Update(TEntity obj);
        bool Delete(TEntity obj);
    }
}
