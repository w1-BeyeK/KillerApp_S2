using KillerApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KillerApp.Core.Models
{
    public class Administrator: Account
    {
        private readonly IGenericRepository<Administrator> repo;

        public Administrator(IGenericRepository<Administrator> repo)
        {
            this.repo = repo;
        }

        public string Phone { get; set; }
    }
}
