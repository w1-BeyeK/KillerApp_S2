using KillerApp.Api.Models;
using KillerApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace KillerApp.Api.Context.UserContext
{
    public class UserMSSQLContext : IGenericContext<User>
    {
        public bool Delete(User obj)
        {
            throw new NotImplementedException();
        }

        public User FindById(User obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetWithFilter(Expression<Func<User, bool>> filter = null, Func<IQueryable<User>, IOrderedQueryable<User>> orderBy = null)
        {
            throw new NotImplementedException();
        }

        public bool Insert(User obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(User obj)
        {
            throw new NotImplementedException();
        }
    }
}
