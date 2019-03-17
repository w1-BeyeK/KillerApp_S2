using KillerApp.Api.Models;
using KillerApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KillerApp.Api.Context.ActivityContext
{
    public class ActivityMemoryContext : IGenericContext<Activity>
    {
        public bool Delete(Activity obj)
        {
            throw new NotImplementedException();
        }

        public Activity FindById(Activity obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Activity> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Activity> GetWithFilter(System.Linq.Expressions.Expression<Func<Activity, bool>> filter = null, Func<IQueryable<Activity>, IOrderedQueryable<Activity>> orderBy = null)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Activity obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Activity obj)
        {
            throw new NotImplementedException();
        }
    }
}
