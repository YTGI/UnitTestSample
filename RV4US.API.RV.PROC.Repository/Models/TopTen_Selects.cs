using System;
using System.Collections.Generic;

namespace RV4US.API.RV.PROC.Repository.Models
{
    public partial class TopTen_Selects
    {
        public long Id { get; set; }
        public long TopTenFiltersId { get; set; }
        public long TopTenItemsId { get; set; }
        public int Order { get; set; }

        public virtual TopTen_Filters TopTenFilters { get; set; }
    }
}
