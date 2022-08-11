using System;
using System.Collections.Generic;

namespace RV4US.API.RV.PROC.Repository.Models
{
    public partial class ClickOuts
    {
        public long Id { get; set; }
        public DateTime DateAdded { get; set; }
        public string SessionId { get; set; }
        public long? TopTenFiltersId { get; set; }
        public long? URLId { get; set; }
        public string EntireURI { get; set; }
    }
}
