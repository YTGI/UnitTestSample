// --------------------------------------------------------------------------------
/*  Copyright © 2020, Yasgar Technology Group, Inc.
    Any unauthorized review, use, disclosure or distribution is prohibited.

    Purpose: Test RVModels Controller actions

    Description: 

*/
// --------------------------------------------------------------------------------

using Microsoft.EntityFrameworkCore;
using RV4US.API.RV.PROC.Repository;
using RV4US.API.RV.PROC.Repository.Context;
using RV4US.API.RV.PROC.Repository.Models;
using System.Linq;
using System.Threading.Tasks;

using Xunit;

namespace RV4US.API.RV.PROC.X.Unit.Tests
{
    public class RVModelTests
    {

        /// <summary>
        /// Get RVModels Paged with no params
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task GETRVModelTest01()
        {
            DbContextOptionsBuilder<RVResearchContext> optionsBuilder = new();
            optionsBuilder.UseInMemoryDatabase("InMemoryDB");

            RVResearchContext _dbContext = new(optionsBuilder.Options);

            SeedTopTen _seed = new();
            _seed.Seed(_dbContext);

            RVResearchRep _repository = new(_dbContext);

            RVModels _result = await _repository.GetRVModelsByIdAsync(229);

            Assert.True(_result.FeatureBase.Any());

        }





    }
}
