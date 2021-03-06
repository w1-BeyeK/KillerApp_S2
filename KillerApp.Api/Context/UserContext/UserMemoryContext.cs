﻿using KillerApp.Api.Interface;
using KillerApp.Api.Models;
using KillerApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace KillerApp.Api.Context.UserContext
{
    public class UserMemoryContext : IGenericContext<User>
    {
        public List<User> Items { get; set; }

        public UserMemoryContext()
        {
            Items = new List<User>();
            Items.AddRange(new List<User>
            {
                new User()
                {
                    Id = 1,
                    Name = "Kevin Beye",
                    Email = "k.beye@student.fontys.nl",
                    Password = "Test123",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                },
                new User()
                {
                    Id = 2,
                    Name = "Kevin Test",
                    Email = "k.beye@student.fontys.nl123",
                    Password = "Test321",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                },
                new User()
                {
                    Id = 3,
                    Name = "Kevin NIKS",
                    Email = "k.beye@student.asdfasdg.nl",
                    Password = "Test54321",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                },
                new User()
                {
                    Id = 4,
                    Name = "Kevin vd Wouw",
                    Email = "k.vanderwouw@student.asdfasdg.nl",
                    Password = "Test54321",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                },
            });
        }

        public bool Delete(User obj)
        {
            try
            {
                Items.Remove(obj);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public User FindById(User obj)
        {
            return Items.FirstOrDefault(u => u.Id == obj.Id);
        }

        public IEnumerable<User> GetAll()
        {
            return GetWithFilter(orderBy: (user) => user.OrderBy(x => x.Name));
        }

        public IEnumerable<User> GetWithFilter(Expression<Func<User, bool>> filter = null, Func<IQueryable<User>, IOrderedQueryable<User>> orderBy = null)
        {
            IQueryable<User> query = Items.AsQueryable();

            if(filter != null)
                query = query.Where(filter);

            if (orderBy != null)
                return orderBy(query).ToList();
            return query.OrderBy(u => u.Name).ToList();
        }

        public User Insert(User obj)
        {
            try
            {
                long id = Items.Count > 0 ? Items.OrderByDescending(u => u.Id).FirstOrDefault().Id + 1 : 1;
                obj.Id = id;
                Items.Add(obj);
                return Items.OrderByDescending(u => u.Id).FirstOrDefault();
            }
            catch (Exception)
            {
                return default(User);
            }
        }

        public User Update(User obj)
        {
            try
            {
                var user = Items.FirstOrDefault(u => u.Id == obj.Id);
                Items.Remove(user);
                Items.Add(obj);
                return obj;
            }
            catch (Exception)
            {
                return default(User);
            }
        }
    }
}
