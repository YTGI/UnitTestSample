using System;
using System.Collections.Generic;

namespace RV4US.API.RV.PROC.Repository.Models
{
    public partial class Addresses
    {
        public Addresses()
        {
            Manufacturers = new HashSet<Manufacturers>();
        }

        public long Id { get; set; }
        public Guid UniqueId { get; set; }
        public long AddressTypeId { get; set; }
        public string Description { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public int StateId { get; set; }
        public string Postal { get; set; }
        public string ZipPlus { get; set; }
        public bool IsActive { get; set; }
        public bool IsPrimary { get; set; }
        public int CountyId { get; set; }
        public long WhoMod { get; set; }
        public long WhoAdded { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateMod { get; set; }
        public string Notes { get; set; }

        public virtual LuItems AddressType { get; set; }

        public virtual ICollection<Manufacturers> Manufacturers { get; set; }
    }
}
