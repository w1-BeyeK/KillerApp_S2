using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using KillerApp.Repository.Interfaces;

namespace KillerApp.Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T:class 
    {

        private readonly IGenericContext<T> gc;
        public GenericRepository(IGenericContext<T> gc)
        {
            this.gc = gc;
        }

        public void Delete(T obj)
        {
            this.gc.Delete(obj);
        }

        public IEnumerable<T> GetAll()
        {
            return this.gc.GetAll();
        }

        public IEnumerable<T> GetWithFilter(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null)
        {
            return this.gc.GetWithFilter(filter, orderBy);
        }

        public void Insert(T obj)
        {
            this.gc.Insert(obj);
        }

        public void Update(T obj)
        {
            this.gc.Update(obj);
        }
    }
}
