using KillerApp.Api.Database;
using KillerApp.Api.Interface;
using KillerApp.Api.Models;
using KillerApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace KillerApp.Api.Context.CustomerContext
{
    public class CustomerMSSQLContext : IGenericContext<Customer>
    {
        private MSSQLDatabase db;

        private readonly string conn = "Server=mssql.fhict.local;Database=dbi409368;User Id=dbi409368;Password=Heclepra9;";
        private readonly string table = "users";

        public CustomerMSSQLContext()
        {
            db = new MSSQLDatabase(conn);
            Items = new List<Customer>();
        }

        public IEnumerable<Customer> Items { get; set; }

        public bool Delete(Customer obj)
        {
            string query = $"delete from {table} where id = '{obj.Id}'";
            return db.ExecOther(query);
        }

        public Customer FindById(Customer obj)
        {
            return getCustomers().FirstOrDefault(i => i.Id == obj.Id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return getCustomers();
        }

        public IEnumerable<Customer> GetWithFilter(Expression<Func<Customer, bool>> filter = null,
            Func<IQueryable<Customer>, IOrderedQueryable<Customer>> orderBy = null)
        {
            List<Customer> customers = getCustomers().ToList();

            IQueryable<Customer> query = customers.AsQueryable();

            if (filter != null)
                query.Where(filter);

            if (orderBy != null)
                return orderBy(query).ToList();
            return query.ToList();
        }

        public bool Insert(Customer obj)
        {
            string query = $"insert into {table}()";
            return db.ExecOther(query);
        }

        public bool Update(Customer obj)
        {
            try
            {
                string query = "update xxx";
                return db.ExecOther(query);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private IEnumerable<Customer> getCustomers()
        {
            DataTable dt = db.ExecSelect($"select * from {table}");

            foreach (DataRow dr in dt.Rows)
            {
                yield return new Customer()
                {
                    Id = int.Parse(dr["Id"].ToString()),
                    FirstName = dr["FirstName"].ToString(),
                    LastName = dr["LastName"].ToString(),
                    MiddleName = dr["MiddleName"].ToString(),
                    Email = dr["Email"].ToString(),
                    Address = dr["Address"].ToString(),
                    City = dr["City"].ToString(),
                    Country = dr["Country"].ToString(),
                    CountryCode = dr["CountryCode"].ToString().ToArray(),
                    Password = dr["Password"].ToString(),
                    ZipCode = dr["ZipCode"].ToString(),
                    BirthDate = DateTime.TryParse(dr["BirthDate"].ToString(), out DateTime date) ? date : DateTime.Now
                };
            }
        }
    }
}
