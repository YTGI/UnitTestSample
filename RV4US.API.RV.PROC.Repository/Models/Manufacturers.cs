using System;
using System.Collections.Generic;

namespace RV4US.API.RV.PROC.Repository.Models
{
    public partial class Manufacturers
    {
        public Manufacturers()
        {
            Brands = new HashSet<Brands>();
            Features_Manufacturer = new HashSet<Features_Manufacturer>();
            Addresses = new HashSet<Addresses>();
            Phones = new HashSet<Phones>();
            URLs = new HashSet<URLs>();
        }

        public long Id { get; set; }
        public Guid UniqueId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string HomePageURL { get; set; }
        public string LogoURI { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
        public long WhoMod { get; set; }
        public long WhoAdded { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateMod { get; set; }
        public string Summary { get; set; }

        public virtual ICollection<Brands> Brands { get; set; }
        public virtual ICollection<Features_Manufacturer> Features_Manufacturer { get; set; }

        public virtual ICollection<Addresses> Addresses { get; set; }
        public virtual ICollection<Phones> Phones { get; set; }
        public virtual ICollection<URLs> URLs { get; set; }
    }
}
