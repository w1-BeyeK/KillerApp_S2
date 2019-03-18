using KillerApp.Api.Models;
using KillerApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace KillerApp.Api.Context.AdministratorContext
{
    public class AdministratorMemoryContext : IGenericContext<Administrator>
    {
        public bool Delete(Administrator obj)
        {
            throw new NotImplementedException();
        }

        public Administrator FindById(Administrator obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Administrator> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Administrator> GetWithFilter(Expression<Func<Administrator, bool>> filter = null, Func<IQueryable<Administrator>, IOrderedQueryable<Administrator>> orderBy = null)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Administrator obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Administrator obj)
        {
            throw new NotImplementedException();
        }

        Administrator IGenericContext<Administrator>.Insert(Administrator obj)
        {
            throw new NotImplementedException();
        }

        Administrator IGenericContext<Administrator>.Update(Administrator obj)
        {
            throw new NotImplementedException();
        }
    }
}
