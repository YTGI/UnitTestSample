using System;
using System.Collections.Generic;

namespace RV4US.API.RV.PROC.Repository.Models
{
    public partial class Uploads
    {
        public long Id { get; set; }
        public Guid UniqueId { get; set; }
        public int UploadTypeId { get; set; }
        public int? ReferenceTypeId { get; set; }
        public long? ReferenceId { get; set; }
        public string StoragePath { get; set; }
        public bool IsActive { get; set; }
        public long WhoMod { get; set; }
        public long WhoAdded { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateMod { get; set; }
        public DateTime DateLastVerified { get; set; }
    }
}
