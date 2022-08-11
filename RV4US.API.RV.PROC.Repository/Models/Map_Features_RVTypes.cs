using System;
using System.Collections.Generic;

namespace RV4US.API.RV.PROC.Repository.Models
{
    public partial class Map_Features_RVTypes
    {
        public long FeaturesBaseId { get; set; }
        public int RVTypeId { get; set; }

        public virtual Features_Base FeaturesBase { get; set; }
    }
}
