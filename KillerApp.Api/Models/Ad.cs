using KillerApp.Repository.Interfaces;
using KillerApp.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace KillerApp.Api.Models
{
    public enum AdStatus
    {
        Active,
        Inactive,
        Unavailable,
        Deleted
    }
    public class Ad: DataObject
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public AdStatus AdStatus { get; set; }

        public City City { get; set; }
        public Customer Customer { get; set; }
    }
}
