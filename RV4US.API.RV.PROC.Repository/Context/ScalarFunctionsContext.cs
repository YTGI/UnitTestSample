using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RV4US.API.RV.PROC.Repository.Models;

#nullable disable

namespace RV4US.API.RV.PROC.Repository.Context
{
    public partial class RVResearchContext : DbContext
    {

        [DbFunction("fGetRVModelCountForTopTenItem", "rvs")]
        public static int GetRVModelCountForTopTenItem(string TTShortName)
        {
            throw new NotImplementedException();
        }



    }
}
