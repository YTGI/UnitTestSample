using System;
using System.Collections.Generic;

namespace RV4US.API.RV.PROC.Repository.Models
{
    public partial class RVModels
    {
        public RVModels()
        {
            FeatureBase = new HashSet<Features_Base>();
            FunctionalBenefit = new HashSet<FunctionalBenefits>();
            URLs = new HashSet<URLs>();
        }

        public long Id { get; set; }
        public Guid UniqueId { get; set; }
        public long BrandsId { get; set; }
        public int ModelYear { get; set; }
        public string ModelNumber { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public string PostSuffix { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string LogoURI { get; set; }
        public string Notes { get; set; }
        public string Summary { get; set; }
        public int RVTypeId { get; set; }
        public int? RVSubTypeId { get; set; }
        public int? RVCategoryId { get; set; }
        public bool IsActive { get; set; }
        public long WhoMod { get; set; }
        public long WhoAdded { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateMod { get; set; }

        public virtual Brands Brands { get; set; }
        public virtual RVModels_Specs RVModels_Specs { get; set; }

        public virtual ICollection<Features_Base> FeatureBase { get; set; }
        public virtual ICollection<FunctionalBenefits> FunctionalBenefit { get; set; }
        public virtual ICollection<URLs> URLs { get; set; }
    }
}
