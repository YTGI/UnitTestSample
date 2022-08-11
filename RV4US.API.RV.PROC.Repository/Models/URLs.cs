using System;
using System.Collections.Generic;

namespace RV4US.API.RV.PROC.Repository.Models
{
    public partial class URLs
    {
        public URLs()
        {
            Brands = new HashSet<Brands>();
            Manufacturers = new HashSet<Manufacturers>();
            RVModels = new HashSet<RVModels>();
        }

        public long Id { get; set; }
        public Guid UniqueId { get; set; }
        public long URLTypeId { get; set; }
        public string EntireURI { get; set; }
        public bool IsActive { get; set; }
        public long WhoMod { get; set; }
        public long WhoAdded { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateMod { get; set; }

        public virtual ICollection<Brands> Brands { get; set; }
        public virtual ICollection<Manufacturers> Manufacturers { get; set; }
        public virtual ICollection<RVModels> RVModels { get; set; }
    }
}
