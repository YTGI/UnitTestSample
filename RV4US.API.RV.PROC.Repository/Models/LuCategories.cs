using System;
using System.Collections.Generic;

namespace RV4US.API.RV.PROC.Repository.Models
{
    public partial class LuCategories
    {
        public LuCategories()
        {
            LuItems = new HashSet<LuItems>();
        }

        public long Id { get; set; }
        public string ShortName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string WhoMod { get; set; }
        public string WhoAdd { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateMod { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<LuItems> LuItems { get; set; }
    }
}
