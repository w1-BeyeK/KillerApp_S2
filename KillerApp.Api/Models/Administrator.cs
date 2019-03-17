using KillerApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace KillerApp.Api.Models
{
    public class Administrator: Account
    {
        public string Phone { get; set; }
    }
}
