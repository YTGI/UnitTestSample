using System;
using System.Collections.Generic;

namespace RV4US.API.RV.PROC.Repository.Models
{
    public partial class FunctionalBenefits
    {
        public FunctionalBenefits()
        {
            RVModels = new HashSet<RVModels>();
            TopTen = new HashSet<TopTenItems>();
        }

        public long Id { get; set; }
        public Guid UniqueId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Summary { get; set; }
        public string Notes { get; set; }
        public long CategoryId { get; set; }
        public bool IsActive { get; set; }
        public long WhoMod { get; set; }
        public long WhoAdded { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateMod { get; set; }

        public virtual ICollection<RVModels> RVModels { get; set; }
        public virtual ICollection<TopTenItems> TopTen { get; set; }
    }
}
