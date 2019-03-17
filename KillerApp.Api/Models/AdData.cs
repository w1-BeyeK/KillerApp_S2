using KillerApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KillerApp.Api.Models
{
    public enum AdType
    {
        Click,
        Visible,
        Lead
    }

    public class AdData
    {
        public DateTime DateTime { get; set; }
        public AdType AdType { get; set; }

        public Ad Ad { get; set; }
    }
}
