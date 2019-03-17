using KillerApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KillerApp.Core.Models
{
    public class Activity: DataObject
    {
        private readonly IGenericRepository<Activity> repo;

        public Activity(IGenericRepository<Activity> repo)
        {
            this.repo = repo;
        }

        public string Name { get; set; }
        public DateTime Date { get; set; }

        public List<User> Users { get; set; }
        public City City { get; set; }
    }
}
