using System;
using System.Collections.Generic;

namespace RV4US.API.RV.PROC.Repository.Models
{
    public partial class Brands
    {
        public Brands()
        {
            RVModels = new HashSet<RVModels>();
            URLs = new HashSet<URLs>();
        }

        public long Id { get; set; }
        public long ManufacturersId { get; set; }
        public Guid UniqueId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string LogoURI { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
        public long WhoMod { get; set; }
        public long WhoAdded { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateMod { get; set; }
        public string Summary { get; set; }

        public virtual Manufacturers Manufacturers { get; set; }
        public virtual ICollection<RVModels> RVModels { get; set; }

        public virtual ICollection<URLs> URLs { get; set; }
    }
}
