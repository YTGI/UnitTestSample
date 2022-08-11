using System;
using System.Collections.Generic;

namespace RV4US.API.RV.PROC.Repository.Models
{
    public partial class TopTen_Results
    {
        public long Id { get; set; }
        public long TopTenFiltersId { get; set; }
        public long TopTenSelectsId { get; set; }
        public long RVModelId { get; set; }

        public virtual TopTen_Filters TopTenFilters { get; set; }
    }
}
