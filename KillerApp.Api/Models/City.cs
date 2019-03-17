using KillerApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KillerApp.Api.Models
{
    public class City: DataObject
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
