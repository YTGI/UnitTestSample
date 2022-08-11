using System;
using System.Collections.Generic;

namespace RV4US.API.RV.PROC.Repository.Models
{
    public partial class LuItems
    {
        public LuItems()
        {
            Addresses = new HashSet<Addresses>();
            Phones = new HashSet<Phones>();
        }

        public long Id { get; set; }
        public long LuCatId { get; set; }
        public string LuCode { get; set; }
        public string LuItemDesc { get; set; }
        public int EnumValue { get; set; }
        public string LuValue { get; set; }
        public string LuValue2 { get; set; }
        public bool IsActive { get; set; }
        public bool? LuBoolean { get; set; }
        public long LuQuantity { get; set; }
        public DateTime? LuDate1 { get; set; }
        public DateTime? LuDate2 { get; set; }
        public string WhoMod { get; set; }
        public string WhoAdd { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateMod { get; set; }

        public virtual LuCategories LuCat { get; set; }
        public virtual ICollection<Addresses> Addresses { get; set; }
        public virtual ICollection<Phones> Phones { get; set; }
    }
}
