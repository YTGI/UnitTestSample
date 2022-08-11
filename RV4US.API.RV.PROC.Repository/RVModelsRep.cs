// --------------------------------------------------------------------------------
/*  Copyright © 2020, Yasgar Technology Group, Inc.
	Any unauthorized review, use, disclosure or distribution is prohibited.

	Purpose: Provide repository calls using the RVResearchContext

	Description: 

*/
// --------------------------------------------------------------------------------


using Microsoft.EntityFrameworkCore;

using RV4US.API.RV.PROC.Repository.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using YTG.Framework.Extensions;
using YTG.Framework.Models;

namespace RV4US.API.RV.PROC.Repository
{
    public partial class RVResearchRep : IRVResearchRep
    {


        /// <summary>
        /// Get one RVModels by Id
        /// </summary>
        /// <returns></returns>
        public async Task<RVModels> GetRVModelsByIdAsync(long Id)
        {

            return await rvResearchContext.RVModels.Where(i => i.Id == Id)
                                                    .Include(s => s.RVModels_Specs)
                                                    .Include(u => u.URLs)
                                                    .Include(b => b.Brands)
                                                    .Include(f => f.FeatureBase)
                                                    .Include(f => f.FunctionalBenefit)
                                                    .AsNoTracking()
                                                    .FirstOrDefaultAsync();
        }


    }
}
