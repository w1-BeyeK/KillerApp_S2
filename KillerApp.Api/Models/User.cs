using System;
using System.Collections.Generic;
using System.Text;

namespace KillerApp.Api.Models
{
    public class User : DataObject
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public List<Activity> Activities { get; set; }
    }
}
