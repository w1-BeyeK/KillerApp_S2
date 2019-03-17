using KillerApp.Repository.Interfaces;
using KillerApp.Repository.Repositories;
using System;
using KillerApp.Api.Context.CustomerContext;
using KillerApp.Api.Context.AdminstratorContext;
using KillerApp.Api.Context.AdContext;
using KillerApp.Api.Context.UserContext;
using KillerApp.Api.Context.ActivityContext;
using KillerApp.Api.Context.CityContext;

namespace KillerApp.Api.Models
{
    public class UnitOfWork : IDisposable
    {
        private IGenericRepository<Customer> customerRepository;
        private IGenericRepository<Administrator> administratorRepository;
        private IGenericRepository<Ad> adRepository;
        private IGenericRepository<Activity> activityRepository;
        private IGenericRepository<User> userRepository;
        private IGenericRepository<City> cityRepository;

        private static UnitOfWork instance = null;

        public static UnitOfWork GetInstance()
        {
            if (instance == null)
            {
                instance = new UnitOfWork();
            }
            return instance;
        }

        public IGenericRepository<Customer> CustomerRepository
        {
            get
            {
                if (customerRepository == null)
                {
                    customerRepository = new GenericRepository<Customer>(new CustomerMSSQLContext());
                }
                return customerRepository;
            }
        }

        public IGenericRepository<Administrator> AdministratorRepository
        {
            get
            {
                if (administratorRepository == null)
                {
                    administratorRepository = new GenericRepository<Administrator>(new AdministratorMSSQLContext());
                }
                return administratorRepository;
            }
        }

        public IGenericRepository<Ad> AdRepository
        {
            get
            {
                if (adRepository == null)
                {
                    adRepository = new GenericRepository<Ad>(new AdMSSQLContext());
                }
                return adRepository;
            }
        }

        public IGenericRepository<User> UserRepository
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new GenericRepository<User>(new UserMemoryContext());
                }
                return userRepository;
            }
        }

        public IGenericRepository<Activity> ActivityRepository
        {
            get
            {
                if (activityRepository == null)
                {
                    activityRepository = new GenericRepository<Activity>(new ActivityMSSQLContext());
                }
                return activityRepository;
            }
        }

        public IGenericRepository<City> CityRepository
        {
            get
            {
                if (cityRepository == null)
                {
                    cityRepository= new GenericRepository<City>(new CityMSSQLContext());
                }
                return cityRepository;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
