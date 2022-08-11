using System;
using System.Collections.Generic;

namespace RV4US.API.RV.PROC.Repository.Models
{
    public partial class Users
    {
        public long Id { get; set; }
        public Guid UniqueId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public long WhoMod { get; set; }
        public long WhoAdded { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateMod { get; set; }
    }
}
