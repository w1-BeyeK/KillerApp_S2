using KillerApp.Api.Models;
using KillerApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace KillerApp.Api.Context.AdContext
{
    public class AdMSSQLContext : IGenericContext<Ad>
    {
        public bool Delete(Ad obj)
        {
            throw new NotImplementedException();
        }

        public Ad FindById(Ad obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ad> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ad> GetWithFilter(Expression<Func<Ad, bool>> filter = null, Func<IQueryable<Ad>, IOrderedQueryable<Ad>> orderBy = null)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Ad obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Ad obj)
        {
            throw new NotImplementedException();
        }

        Ad IGenericContext<Ad>.Insert(Ad obj)
        {
            throw new NotImplementedException();
        }

        Ad IGenericContext<Ad>.Update(Ad obj)
        {
            throw new NotImplementedException();
        }
    }
}
