using KillerApp.Api.Models;
using KillerApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace KillerApp.Api.Context.CustomerContext
{
    public class CustomerMemoryContext : IGenericContext<Customer>
    {
        public List<Customer> Items { get; set; }

        public bool Delete(Customer obj)
        {
            throw new NotImplementedException();
        }

        public Customer FindById(Customer obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetWithFilter(Expression<Func<Customer, bool>> filter = null, Func<IQueryable<Customer>, IOrderedQueryable<Customer>> orderBy = null)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Customer obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Customer obj)
        {
            throw new NotImplementedException();
        }
    }
}
