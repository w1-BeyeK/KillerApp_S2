using KillerApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KillerApp.Core.Models
{
    public abstract class Account: DataObject
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? BirthDate { get; set; }

        public string Token { get; set; }
    }
}
