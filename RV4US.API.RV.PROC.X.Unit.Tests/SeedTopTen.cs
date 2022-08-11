using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RV4US.API.RV.PROC.Repository.Context;
using RV4US.API.RV.PROC.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace RV4US.API.RV.PROC.X.Unit.Tests
{
    public class SeedTopTen
    {

        private static readonly object _ttlock = new();
        private static bool _ttdatabaseInitialized;

        public bool Seed(RVResearchContext dbContext)
        {
            lock (_ttlock)
            {
                // Multiple classes calling the factory can try to add records multiple times
                if (!_ttdatabaseInitialized)
                {
                    dbContext.Database.EnsureDeleted();
                    dbContext.Database.EnsureCreated();
                    //dbContext.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.TrackAll;

                    SeedManufacturers(dbContext);
                    SeedBrands(dbContext);
                    SeedFeaturesBase(dbContext);
                    SeedFunctionalBenefits(dbContext);

                    SeedRVModels(dbContext);
                    SeedRVModels_Spec(dbContext);

                    SeedRVModelsToFeatures(dbContext);

                    _ttdatabaseInitialized = true;
                }
            }

            return _ttdatabaseInitialized;

        }


        /// <summary>
        /// Seed the Manufacturers, the parent object
        /// </summary>
        /// <param name="dbContext"></param>
        private void SeedManufacturers(RVResearchContext dbContext)
        {
            try
            {

                dbContext.Manufacturers.AddRange(
                    new Manufacturers() { DateAdded = DateTime.Now, DateMod = DateTime.Now, Id = 15, IsActive = true, UniqueId = new Guid("98ABF5CF-6465-47A6-A20E-4B49C579EA4B"), Name = "DRV Luxury Suites", Notes = "Is not secure. No https. WWW resolves to just drvsuites.com", ShortName = "DRVLUXURYSUITES", WhoAdded = 1, WhoMod = 1 },
                    new Manufacturers() { DateAdded = DateTime.Now, DateMod = DateTime.Now, Id = 24, IsActive = true, UniqueId = new Guid("B6718DA9-6780-4D28-8097-C61954DEA3D0"), Name = "Forest River", Notes = "Owned by Berkshire Hathaway", ShortName = "FORESTRIVER", WhoAdded = 1, WhoMod = 1 },
                    new Manufacturers() { DateAdded = DateTime.Now, DateMod = DateTime.Now, Id = 74, IsActive = true, UniqueId = new Guid("759CF2C7-747C-4559-85F5-9167D6D6234B"), Name = "Winnebago Industries", Notes = "", ShortName = "WINNEBEGO", WhoAdded = 1, WhoMod = 1 }
                );

                dbContext.SaveChanges();

            }
            catch (Exception)
            { }
        }


        /// <summary>
        /// Seed the Brands 
        /// </summary>
        /// <param name="dbContext"></param>
        private void SeedBrands(RVResearchContext dbContext)
        {
            try
            {
                dbContext.Brands.AddRange(
                    new Brands() { ManufacturersId = 15, ShortName = "DRVLUXURYSUITES_MOBILESUITES", Id = 116, IsActive = true, UniqueId = new Guid("B0130BDE-488D-4995-8124-F83B8B5A75FB"), Name = "Mobile Suites", Notes = "Luxury 5th wheel", WhoAdded = 1, WhoMod = 1, DateAdded = DateTime.Now, DateMod = DateTime.Now },
                    new Brands() { ManufacturersId = 74, ShortName = "WINNEBEGO_VISTA", Id = 532, IsActive = true, UniqueId = new Guid("4384D3A0-4E5C-43E0-8A22-42A38A568FD2"), Name = "Vista", Notes = "", WhoAdded = 1, WhoMod = 1, DateAdded = DateTime.Now, DateMod = DateTime.Now },
                    new Brands() { ManufacturersId = 74, ShortName = "WINNEBEGO_VOYAGE", Id = 554, IsActive = true, UniqueId = new Guid("069C13B9-62BB-4D29-B364-ACC0FF8BD9AD"), Name = "Voyage", Notes = "", WhoAdded = 1, WhoMod = 1, DateAdded = DateTime.Now, DateMod = DateTime.Now },
                    new Brands() { ManufacturersId = 24, ShortName = "FORESTRIVER_BERKSHIREXLT", Id = 581, IsActive = true, UniqueId = new Guid("5440C20C-9FEA-4313-91BA-593CA6BD6F99"), Name = "Berkshire XLT", Notes = "", WhoAdded = 1, WhoMod = 1, DateAdded = DateTime.Now, DateMod = DateTime.Now },
                    new Brands() { ManufacturersId = 24, ShortName = "FORESTRIVER_CEDARCREEKSILVERBACKEDITION", Id = 586, IsActive = true, UniqueId = new Guid("D950CB87-2CD3-4AA6-9D16-AE15158C3A81"), Name = "Cedar Creek Silverback Edition", Notes = "<p>Dealer stock only.</p>", WhoAdded = 1, WhoMod = 1, DateAdded = DateTime.Now, DateMod = DateTime.Now }

                ) ;

                dbContext.SaveChanges();

            }
            catch (Exception)
            { }
        }

        /// <summary>
        /// Seed the RVModels 
        /// </summary>
        /// <param name="dbContext"></param>
        private void SeedRVModels(RVResearchContext dbContext)
        {
            try
            {
                dbContext.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;

                dbContext.RVModels.AddRange(
                    new RVModels() { BrandsId = 116, RVTypeId = 03, RVSubTypeId = 01, Id = 229, IsActive = true, UniqueId = new Guid("96452E80-9F5D-4ACE-832C-007C612ADD87"), RVCategoryId = 01, ModelYear = 2021, ModelNumber = "40", Prefix = "", Suffix = "KSSB4", PostSuffix = "", Name = "40KSSB4", Notes = "", ShortName = "MOBILESUITES_40KSSB4_2021", Summary = "", WhoAdded = 1, WhoMod = 1, DateAdded = DateTime.Now, DateMod = DateTime.Now },
                    new RVModels() { BrandsId = 554, RVTypeId = 02, RVSubTypeId = 00, Id = 345, IsActive = true, UniqueId = new Guid("35E62FB8-4271-42E2-8949-3FF9ECA6C8A1"), RVCategoryId = 02, ModelYear = 2021, ModelNumber = "3235", Prefix = "V", Suffix = "RL", PostSuffix = "", Name = "V3235RL", Notes = "", ShortName = "VOYAGE_V3235RL_2021", Summary = "", WhoAdded = 1, WhoMod = 1, DateAdded = DateTime.Now, DateMod = DateTime.Now },
                    new RVModels() { BrandsId = 586, RVTypeId = 03, RVSubTypeId = 01, Id = 400, IsActive = true, UniqueId = new Guid("81CF6CB2-B573-42E0-AD9D-11518CB489F6"), RVCategoryId = 01, ModelYear = 2021, ModelNumber = "37", Prefix = "", Suffix = "FLK", PostSuffix = "", Name = "37FLK", Notes = "<p>Dealer stock only.</p>", ShortName = "CEDARCREEKSILVERBACKEDITION_37FLK_2021", Summary = "<p>Dealer stock only.</p>", WhoAdded = 1, WhoMod = 1, DateAdded = DateTime.Now, DateMod = DateTime.Now }
                );

                dbContext.SaveChanges();

            }
            catch (Exception)
            { }
        }

        /// <summary>
        /// Seed the RVModels_Spec
        /// </summary>
        /// <param name="dbContext"></param>
        private void SeedRVModels_Spec(RVResearchContext dbContext)
        {
            try
            {
                dbContext.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;

                dbContext.RVModels_Specs.AddRange(
                    new RVModels_Specs() { RVModelsId = 229, UVW = 13500, GVWR = 16500, HitchWeight_lbs = 2825, Length_Inches = 465, Height_Inches = 161, FreshWaterTotal_Gals = 157, GreyWaterTotal_Gals = 78, WasteWaterTotal_Gals = 78, LPCapacity_lbs = 60, Furnace_BTU = 35000, Sleeps_Number = 7, MSRP = 0.00m, ACUnits_Number = 0, Awnings_Number = 0, FuelTypeId = 0, GeneratorFuelTypeId = 0, Slides_Number = 0, Id = 172 },
                    new RVModels_Specs() { RVModelsId = 345, UVW = 3360, GVWR = 5000, HitchWeight_lbs = 340, Length_Inches = 233, Height_Inches = 124, FreshWaterTotal_Gals = 31, GreyWaterTotal_Gals = 25, WasteWaterTotal_Gals = 25, LPCapacity_lbs = 40, Furnace_BTU = 18000, Sleeps_Number = 3, MSRP = 0.00m, ACUnits_Number = 0, Awnings_Number = 0, FuelTypeId = 0, GeneratorFuelTypeId = 0, Slides_Number = 0, Id = 341 },
                    new RVModels_Specs() { RVModelsId = 400, UVW = 13484, GVWR = 16764, HitchWeight_lbs = 2764, Length_Inches = 493, Height_Inches = 161, FreshWaterTotal_Gals = 69, GreyWaterTotal_Gals = 69, WasteWaterTotal_Gals = 40, LPCapacity_lbs = 0, Furnace_BTU = 0, Sleeps_Number = 6, MSRP = 0.00m, ACUnits_Number = 0, Awnings_Number = 0, FuelTypeId = 0, GeneratorFuelTypeId = 0, Slides_Number = 0, Id = 393 }
                );

                dbContext.SaveChanges();

            }
            catch (Exception)
            { }
        }

        /// <summary>
        /// Seed the Features Base
        /// </summary>
        /// <param name="dbContext"></param>
        private void SeedFeaturesBase(RVResearchContext dbContext)
        {

            try
            {
                dbContext.Features_Base.AddRange(
                    new Features_Base() { DateAdded = DateTime.Now, DateMod = DateTime.Now, Id = 7, UniqueId = new Guid("6FA6FD7A-A6DD-4D47-8F42-0886D692C19E"), Name = "Secondary A/C", ShortName = "SECONDARYAC", Notes = "", CategoryId = 7, IsActive = true, WhoAdded = 1, WhoMod = 1 },
                    new Features_Base() { DateAdded = DateTime.Now, DateMod = DateTime.Now, Id = 8, UniqueId = new Guid("FA4AD8F8-60BF-4104-BA18-17A94C46F969"), Name = "Secondary A/C with Heat Pump", ShortName = "SECONDARYACWITHHEATPUMP", Notes = "", CategoryId = 7, IsActive = true, WhoAdded = 1, WhoMod = 1 },
                    new Features_Base() { DateAdded = DateTime.Now, DateMod = DateTime.Now, Id = 11, UniqueId = new Guid("DC0DF2BB-4F56-41BE-A0EB-B28112164527"), Name = "Third (3rd) A/C with Heat Pump", ShortName = "THIRD3RDACWITHHEATPUMP", Notes = "", CategoryId = 7, IsActive = true, WhoAdded = 1, WhoMod = 1 },
                    new Features_Base() { DateAdded = DateTime.Now, DateMod = DateTime.Now, Id = 12, UniqueId = new Guid("49B62B19-AE37-49B9-BA4D-96066FBB3684"), Name = "Third (3rd) A/C", ShortName = "THIRD3RDAC", Notes = "", CategoryId = 7, IsActive = true, WhoAdded = 1, WhoMod = 1 },
                    new Features_Base() { DateAdded = DateTime.Now, DateMod = DateTime.Now, Id = 23, UniqueId = new Guid("E40A5CB0-A8B7-4869-98F7-7CEBEBB1682A"), Name = "Awning Lighting", ShortName = "AWNINGLIGHTING", Notes = "", CategoryId = 6, IsActive = true, WhoAdded = 1, WhoMod = 1 },
                    new Features_Base() { DateAdded = DateTime.Now, DateMod = DateTime.Now, Id = 28, UniqueId = new Guid("052E40A5-4240-4964-9B49-1D73304BCCD7"), Name = "Booth Dinette", ShortName = "BOOTHDINETTE", Notes = "", CategoryId = 9, IsActive = true, WhoAdded = 1, WhoMod = 1 },
                    new Features_Base() { DateAdded = DateTime.Now, DateMod = DateTime.Now, Id = 68, UniqueId = new Guid("16B2BE20-7372-44CB-BF56-E520C31DC6EA"), Name = "Fireplace", ShortName = "FIREPLACE", Notes = "", CategoryId = 8, IsActive = true, WhoAdded = 1, WhoMod = 1 },
                    new Features_Base() { DateAdded = DateTime.Now, DateMod = DateTime.Now, Id = 104, UniqueId = new Guid("832B0264-26F6-4D70-8596-3C8B511571A7"), Name = "Kitchen island", ShortName = "KITCHENISLAND", Notes = "", CategoryId = 9, IsActive = true, WhoAdded = 1, WhoMod = 1 },
                    new Features_Base() { DateAdded = DateTime.Now, DateMod = DateTime.Now, Id = 110, UniqueId = new Guid("31A2F01C-DDC0-44CA-A7D0-BA1B8C0F2BFD"), Name = "Microwave/Convection Combo", ShortName = "MICROWAVECONVECTIONCOMBO", Notes = "", CategoryId = 9, IsActive = true, WhoAdded = 1, WhoMod = 1 },
                    new Features_Base() { DateAdded = DateTime.Now, DateMod = DateTime.Now, Id = 123, UniqueId = new Guid("FB989601-1226-463B-802A-6918018AEC66"), Name = "Pantry", ShortName = "PANTRY", Notes = "", CategoryId = 9, IsActive = true, WhoAdded = 1, WhoMod = 1 },
                    new Features_Base() { DateAdded = DateTime.Now, DateMod = DateTime.Now, Id = 145, UniqueId = new Guid("67CA8681-A67C-4562-A004-3D099A5DFECD"), Name = "Satellite Prep", ShortName = "SATELLITEPREP", Notes = "", CategoryId = 5, IsActive = true, WhoAdded = 1, WhoMod = 1 },
                    new Features_Base() { DateAdded = DateTime.Now, DateMod = DateTime.Now, Id = 146, UniqueId = new Guid("B3391B81-D7EE-4085-8721-91CDE353B668"), Name = "Satellite Dish", ShortName = "SATELLITERECEIVER", Notes = "", CategoryId = 5, IsActive = true, WhoAdded = 1, WhoMod = 1 },
                    new Features_Base() { DateAdded = DateTime.Now, DateMod = DateTime.Now, Id = 184, UniqueId = new Guid("881FB2D5-97E7-4AB3-B32E-E387C64C8F2C"), Name = "A/C", ShortName = "AC", Notes = "", CategoryId = 7, IsActive = true, WhoAdded = 1, WhoMod = 1 }

                );


                dbContext.SaveChanges();

            }
            catch (Exception)
            { }
        }

        /// <summary>
        /// Seed the Functional Benefits
        /// </summary>
        /// <param name="dbContext"></param>
        private void SeedFunctionalBenefits(RVResearchContext dbContext)
        {
            try
            {

                dbContext.FunctionalBenefits.AddRange(
                    new FunctionalBenefits() { DateAdded = DateTime.Now, DateMod = DateTime.Now, Id = 1, UniqueId = new Guid("F6E6D43F-A794-4C88-9961-A25D128F5423"), Name = "Access to refrigerator while closed", ShortName = "ACCESSTOREFRIGERATORWHILECLOSED", Notes = "", CategoryId = 1, IsActive = true, WhoAdded = 1, WhoMod = 1 },
                    new FunctionalBenefits() { DateAdded = DateTime.Now, DateMod = DateTime.Now, Id = 2, UniqueId = new Guid("6BD820D8-DBF5-44B8-B22E-4B16953F8CEB"), Name = "Access to bathroom while closed", ShortName = "ACCESSTOBATHROOMWHILECLOSED", Notes = "", CategoryId = 1, IsActive = true, WhoAdded = 1, WhoMod = 1 },
                    new FunctionalBenefits() { DateAdded = DateTime.Now, DateMod = DateTime.Now, Id = 3, UniqueId = new Guid("B57DAED0-D781-44A1-BDA6-B95FE842C1FF"), Name = "Access to bed while closed", ShortName = "ACCESSTOBEDWHILECLOSED", Notes = "", CategoryId = 1, IsActive = true, WhoAdded = 1, WhoMod = 1 },
                    new FunctionalBenefits() { DateAdded = DateTime.Now, DateMod = DateTime.Now, Id = 4, UniqueId = new Guid("1CB97D18-BD16-4BF7-A86B-A7E4C80B12B1"), Name = "ADA Accessible", ShortName = "ADAACCESSIBLE", Notes = "", CategoryId = 1, IsActive = true, WhoAdded = 1, WhoMod = 1 },
                    new FunctionalBenefits() { DateAdded = DateTime.Now, DateMod = DateTime.Now, Id = 5, UniqueId = new Guid("930CCDE4-BF65-46B7-B1FD-D3DF7A6CFDF2"), Name = "Suitable for full-time living", ShortName = "SUITABLEFORFULLTIMELIVING", Notes = "", CategoryId = 1, IsActive = true, WhoAdded = 1, WhoMod = 1 },
                    new FunctionalBenefits() { DateAdded = DateTime.Now, DateMod = DateTime.Now, Id = 6, UniqueId = new Guid("2893CAF3-55C1-4B89-81CF-3EBB2C3B9598"), Name = "Opposing Slides", ShortName = "OPPOSINGSLIDES", Notes = "", CategoryId = 1, IsActive = true, WhoAdded = 1, WhoMod = 1 },
                    new FunctionalBenefits() { DateAdded = DateTime.Now, DateMod = DateTime.Now, Id = 7, UniqueId = new Guid("2BEBBFBB-DDF4-4A70-8189-DD8885756D4D"), Name = "Private Space", ShortName = "PRIVATESPACE", Notes = "", CategoryId = 1, IsActive = true, WhoAdded = 1, WhoMod = 1 },
                    new FunctionalBenefits() { DateAdded = DateTime.Now, DateMod = DateTime.Now, Id = 8, UniqueId = new Guid("79599B93-13DA-4F69-A8B4-BE18491D5CA9"), Name = "Full Body Slide", ShortName = "FULLBODYSLIDE", Notes = "", CategoryId = 1, IsActive = true, WhoAdded = 1, WhoMod = 1 }


                );

                dbContext.SaveChanges();

            }
            catch (Exception)
            { }
        }

        /// <summary>
        /// Map Features to Models for testing of Search
        /// </summary>
        /// <param name="dbContext"></param>
        /// <remarks>Don't change these value unless you're prepared to change the Unit tests</remarks>
        private void SeedRVModelsToFeatures(RVResearchContext dbContext)
        {
            // As of .NET 6, the Map_RVModels_FeatureBase table is no longer exposed
            //RVModels _rv01 = (from rv in dbContext.RVModels
            //                  .Include(f => f.FeatureBase)
            //                  where rv.Id == 229
            //                  select rv).AsTracking().Single();

            RVModels _rv01 = dbContext.RVModels.AsNoTracking().Include(f => f.FeatureBase).Single(r => r.Id == 229);
            _rv01.FeatureBase.Add(dbContext.Features_Base.Where(f => f.Id == 7).FirstOrDefault());
            _rv01.FeatureBase.Add(dbContext.Features_Base.Where(f => f.Id == 8).FirstOrDefault());
            _rv01.FeatureBase.Add(dbContext.Features_Base.Where(f => f.Id == 11).FirstOrDefault());
            _rv01.FeatureBase.Add(dbContext.Features_Base.Where(f => f.Id == 12).FirstOrDefault());
            _rv01.FeatureBase.Add(dbContext.Features_Base.Where(f => f.Id == 184).FirstOrDefault());
            _rv01.FeatureBase.Add(dbContext.Features_Base.Where(f => f.Id == 23).FirstOrDefault());
            _rv01.FeatureBase.Add(dbContext.Features_Base.Where(f => f.Id == 28).FirstOrDefault());
            _rv01.FeatureBase.Add(dbContext.Features_Base.Where(f => f.Id == 68).FirstOrDefault());
            _rv01.FeatureBase.Add(dbContext.Features_Base.Where(f => f.Id == 104).FirstOrDefault());
            _rv01.FeatureBase.Add(dbContext.Features_Base.Where(f => f.Id == 110).FirstOrDefault());
            _rv01.FeatureBase.Add(dbContext.Features_Base.Where(f => f.Id == 123).FirstOrDefault());
            _rv01.FeatureBase.Add(dbContext.Features_Base.Where(f => f.Id == 145).FirstOrDefault());
            _rv01.FeatureBase.Add(dbContext.Features_Base.Where(f => f.Id == 146).FirstOrDefault());
            // dbContext.Entry(_rv01).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            dbContext.SaveChanges();

            RVModels _rv99 = dbContext.RVModels.Include(f => f.FeatureBase).AsNoTracking().Single(r => r.Id == 229);
            string _temp = string.Empty;


        }

    }
}
