using System;
using System.Collections.Generic;

namespace RV4US.API.RV.PROC.Repository.Models
{
    public partial class Features_Manufacturer
    {
        public long Id { get; set; }
        public Guid UniqueId { get; set; }
        public long FeaturesBaseId { get; set; }
        public long ManufacturerId { get; set; }
        public int ModelYear { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Summary { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
        public long WhoMod { get; set; }
        public long WhoAdded { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateMod { get; set; }

        public virtual Features_Base FeaturesBase { get; set; }
        public virtual Manufacturers Manufacturer { get; set; }
    }
}
