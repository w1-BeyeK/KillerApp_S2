using KillerApp.Repository.Interfaces;
using KillerApp.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace KillerApp.Api.Models
{
    public class Customer: Account
    {

        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public char[] CountryCode { get; set; }

        public string ContactAt { get; set; }

        public List<Ad> Ads { get; set; }
    }
}
