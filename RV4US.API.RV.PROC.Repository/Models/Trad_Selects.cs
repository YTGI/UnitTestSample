using System;
using System.Collections.Generic;

namespace RV4US.API.RV.PROC.Repository.Models
{
    public partial class Trad_Selects
    {
        public long Id { get; set; }
        public long TopTenFiltersId { get; set; }
        public long? FeaturesBaseId { get; set; }
        public long? FunctionalBenefitsId { get; set; }

        public virtual TopTen_Filters TopTenFilters { get; set; }
    }
}
