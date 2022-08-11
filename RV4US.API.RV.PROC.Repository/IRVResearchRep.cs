// --------------------------------------------------------------------------------
/*  Copyright © 2020, Yasgar Technology Group, Inc.
	Any unauthorized review, use, disclosure or distribution is prohibited.

	Purpose: Provide repository calls using the RVResearchContext

	Description: 

*/
// --------------------------------------------------------------------------------


using RV4US.API.RV.PROC.Repository.Models;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using YTG.Framework.Models;

namespace RV4US.API.RV.PROC.Repository
{

    public interface IRVResearchRep
    {
        Task<RVModels> GetRVModelsByIdAsync(long Id);

    }
}