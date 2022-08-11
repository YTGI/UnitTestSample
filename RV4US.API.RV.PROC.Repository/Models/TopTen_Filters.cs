using System;
using System.Collections.Generic;

namespace RV4US.API.RV.PROC.Repository.Models
{
    public partial class TopTen_Filters
    {
        public TopTen_Filters()
        {
            TopTen_Results = new HashSet<TopTen_Results>();
            TopTen_Selects = new HashSet<TopTen_Selects>();
            Trad_Results = new HashSet<Trad_Results>();
            Trad_Selects = new HashSet<Trad_Selects>();
        }

        public long Id { get; set; }
        public DateTime DateAdded { get; set; }
        public string SessionId { get; set; }
        public int YearStart { get; set; }
        public int YearEnd { get; set; }
        public string SelectedRVTypes { get; set; }
        public int? GVWR { get; set; }
        public int? HitchWeight_lbs { get; set; }
        public int? Height_inches { get; set; }
        public int? Length_inches { get; set; }
        public int? Sleeps_Number { get; set; }
        public bool ToyHaulerOnly { get; set; }

        public virtual ICollection<TopTen_Results> TopTen_Results { get; set; }
        public virtual ICollection<TopTen_Selects> TopTen_Selects { get; set; }
        public virtual ICollection<Trad_Results> Trad_Results { get; set; }
        public virtual ICollection<Trad_Selects> Trad_Selects { get; set; }
    }
}
