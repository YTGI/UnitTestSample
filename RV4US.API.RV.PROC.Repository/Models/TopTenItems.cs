using System;
using System.Collections.Generic;

namespace RV4US.API.RV.PROC.Repository.Models
{
    public partial class TopTenItems
    {
        public TopTenItems()
        {
            Map_TopTen_RVTypes = new HashSet<Map_TopTen_RVTypes>();
            FeatureBase = new HashSet<Features_Base>();
            FunctionalBenefit = new HashSet<FunctionalBenefits>();
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

        public virtual ICollection<Map_TopTen_RVTypes> Map_TopTen_RVTypes { get; set; }

        public virtual ICollection<Features_Base> FeatureBase { get; set; }
        public virtual ICollection<FunctionalBenefits> FunctionalBenefit { get; set; }
    }
}
