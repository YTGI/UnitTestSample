
SELECT TOP (250) [Id]
      ,[RVModelsId]
      ,[UVW]
      ,[GVWR]
      ,[HitchWeight_lbs]
      ,[Length_Inches]
      ,[Height_Inches]
      ,[FreshWaterTotal_Gals]
      ,[GreyWaterTotal_Gals]
      ,[WasteWaterTotal_Gals]
      ,[LPCapacity_lbs]
      ,[Furnace_BTU]
      ,[WaterHeaterCap_Gals]
      ,[Fireplace_BTU]
      ,[Sleeps_Number]
      ,[MSRP]
      ,[ACUnits_Number]
      ,[Awnings_Number]
      ,[FuelTypeId]
      ,[GeneratorFuelTypeId]
      ,[Slides_Number]
  FROM [RVResearch].[rvs].[RVModels_Specs]

SELECT
	'new RVModels_Specs() { RVModelsId = ' + CONVERT(varchar(100), RVModelsId)
	+ ', UVW = ' + CONVERT(varchar(100), ISNULL(UVW, 0))
	+ ', GVWR = ' + CONVERT(varchar(100), ISNULL(GVWR, 0))
	+ ', HitchWeight_lbs = ' + CONVERT(varchar(100), ISNULL(HitchWeight_lbs, 0))
	+ ', Length_Inches = ' + CONVERT(varchar(100), ISNULL(Length_Inches, 0))
	+ ', Height_Inches = ' + CONVERT(varchar(100), ISNULL(Height_Inches, 0))
	+ ', FreshWaterTotal_Gals = ' + CONVERT(varchar(100), ISNULL(FreshWaterTotal_Gals, 0))
	+ ', GreyWaterTotal_Gals = ' + CONVERT(varchar(100), ISNULL(GreyWaterTotal_Gals, 0))
	+ ', WasteWaterTotal_Gals = ' + CONVERT(varchar(100), ISNULL(WasteWaterTotal_Gals, 0))
	+ ', LPCapacity_lbs = ' + CONVERT(varchar(100), ISNULL(LPCapacity_lbs, 0))
	+ ', Furnace_BTU = ' + CONVERT(varchar(100), ISNULL(Furnace_BTU, 0))
	+ ', Sleeps_Number = ' + CONVERT(varchar(100), ISNULL(Sleeps_Number, 0))
	+ ', MSRP = ' + CONVERT(varchar(100), ISNULL(MSRP, 0.00)) + 'm'
	+ ', ACUnits_Number = ' + CONVERT(varchar(100), ISNULL(ACUnits_Number, 0))
	+ ', Awnings_Number = ' + CONVERT(varchar(100), ISNULL(Awnings_Number, 0))
	+ ', FuelTypeId = ' + CONVERT(varchar(100), ISNULL(FuelTypeId, 0))
	+ ', GeneratorFuelTypeId = ' + CONVERT(varchar(100), ISNULL(GeneratorFuelTypeId, 0))
	+ ', Slides_Number = ' + CONVERT(varchar(100), ISNULL(Slides_Number, 0))
	+ ', Id = ' + CONVERT(varchar(100), Id) + ' },'
  FROM [RVResearch].[rvs].[RVModels_Specs]
  WHERE Id IN (172,225,226,227,228,229,230,231,232,233,234,235,236,237,238,239,316,317,318,319,341,342,343,344,345,
				346,347,393,394,395,396,397,398,399,400,401,402,413,414,415,416,417)