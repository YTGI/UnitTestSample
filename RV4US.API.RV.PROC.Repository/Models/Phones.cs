using System;
using System.Collections.Generic;

namespace RV4US.API.RV.PROC.Repository.Models
{
    public partial class Phones
    {
        public Phones()
        {
            Manufacturers = new HashSet<Manufacturers>();
        }

        public long Id { get; set; }
        public long PhoneTypeId { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public bool IsPrimary { get; set; }
        public long WhoMod { get; set; }
        public long WhoAdded { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateMod { get; set; }

        public virtual LuItems PhoneType { get; set; }

        public virtual ICollection<Manufacturers> Manufacturers { get; set; }
    }
}
