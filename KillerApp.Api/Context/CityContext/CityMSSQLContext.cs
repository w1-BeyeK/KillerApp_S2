using KillerApp.Api.Models;
using KillerApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace KillerApp.Api.Context.CityContext
{
    public class CityMSSQLContext : IGenericContext<City>
    {
        public bool Delete(City obj)
        {
            throw new NotImplementedException();
        }

        public City FindById(City obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> GetWithFilter(Expression<Func<City, bool>> filter = null, Func<IQueryable<City>, IOrderedQueryable<City>> orderBy = null)
        {
            throw new NotImplementedException();
        }

        public bool Insert(City obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(City obj)
        {
            throw new NotImplementedException();
        }
    }
}
