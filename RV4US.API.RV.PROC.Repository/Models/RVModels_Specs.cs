using System;
using System.Collections.Generic;

namespace RV4US.API.RV.PROC.Repository.Models
{
    public partial class RVModels_Specs
    {
        public long Id { get; set; }
        public long RVModelsId { get; set; }
        public int? UVW { get; set; }
        public int? GVWR { get; set; }
        public int? HitchWeight_lbs { get; set; }
        public int? Length_Inches { get; set; }
        public int? Height_Inches { get; set; }
        public int? FreshWaterTotal_Gals { get; set; }
        public int? GreyWaterTotal_Gals { get; set; }
        public int? WasteWaterTotal_Gals { get; set; }
        public int? LPCapacity_lbs { get; set; }
        public int? Furnace_BTU { get; set; }
        public int? WaterHeaterCap_Gals { get; set; }
        public int? Fireplace_BTU { get; set; }
        public int? Sleeps_Number { get; set; }
        public decimal? MSRP { get; set; }
        public int? ACUnits_Number { get; set; }
        public int? Awnings_Number { get; set; }
        public int? FuelTypeId { get; set; }
        public int? GeneratorFuelTypeId { get; set; }
        public int? Slides_Number { get; set; }

        public virtual RVModels RVModels { get; set; }
    }
}
