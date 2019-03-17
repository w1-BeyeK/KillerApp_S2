using System;
using System.Collections.Generic;
using System.Linq;
using KillerApp.Repository.Interfaces;
using Newtonsoft.Json;

namespace KillerApp.Core.Models
{

    public abstract class DataObject
    {
        public DataObject()
        {
        }

        public long Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
                
        public new string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        public virtual object GetIdentifier()
        {
            return Id;
        }
    }
}
