using KillerApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KillerApp.Core.Models
{
    public class City: DataObject
    {
        private readonly IGenericRepository<City> repo;

        public City(IGenericRepository<City> repo)
        {
            this.repo = repo;
        }

        public string Name { get; set; }
        public string Country { get; set; }
    }
}
