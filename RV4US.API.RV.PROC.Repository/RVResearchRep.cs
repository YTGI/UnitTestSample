// --------------------------------------------------------------------------------
/*  Copyright © 2020, Yasgar Technology Group, Inc.
	Any unauthorized review, use, disclosure or distribution is prohibited.

	Purpose: Provide repository calls using the RVResearchContext

	Description: This is the main entry point for the RVResearch repository.
                    All methods are in their respective partial classes

*/
// --------------------------------------------------------------------------------

using RV4US.API.RV.PROC.Repository.Context;

namespace RV4US.API.RV.PROC.Repository
{

    /// <summary>
    /// Methods are in the their individual partial classes
    /// </summary>
    public partial class RVResearchRep : IRVResearchRep
    {

        #region Constructors

        /// <summary>
        /// Constructor with DBContext
        /// </summary>
        /// <param name="context"></param>
        public RVResearchRep(RVResearchContext context)
        {
            rvResearchContext = context;
        }

        #endregion // Constructors

        #region Fields
        #endregion // Fields

        #region Properties

        /// <summary>
        /// Gets or sets the internal access to the DBContext
        /// </summary>
        private RVResearchContext rvResearchContext { get; set; }

        #endregion // Properties

    }
}
