using KillerApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KillerApp.Core.Models
{
    public enum AdType
    {
        Click,
        Visible,
        Lead
    }

    public class AdData
    {
        private readonly IGenericRepository<AdData> repo;

        public AdData(IGenericRepository<AdData> repo)
        {
            this.repo = repo;
        }

        public DateTime DateTime { get; set; }
        public AdType AdType { get; set; }

        public Ad Ad { get; set; }
    }
}
