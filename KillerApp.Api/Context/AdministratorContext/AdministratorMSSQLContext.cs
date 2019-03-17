using KillerApp.Api.Interface;
using KillerApp.Api.Models;
using KillerApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace KillerApp.Api.Context.AdminstratorContext
{
    public class AdministratorMSSQLContext : IGenericContext<Administrator>
    {
        public IEnumerable<Administrator> Items { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public bool Update(Administrator obj)
        {
            throw new NotImplementedException();
        }
    }
}
