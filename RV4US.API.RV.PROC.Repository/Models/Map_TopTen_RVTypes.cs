using System;
using System.Collections.Generic;

namespace RV4US.API.RV.PROC.Repository.Models
{
    public partial class Map_TopTen_RVTypes
    {
        public long TopTenId { get; set; }
        public int RVTypeId { get; set; }

        public virtual TopTenItems TopTen { get; set; }
    }
}
