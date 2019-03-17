using KillerApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KillerApp.Api.Models
{
    public class Activity: DataObject
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public List<User> Users { get; set; }
        public City City { get; set; }
    }
}
