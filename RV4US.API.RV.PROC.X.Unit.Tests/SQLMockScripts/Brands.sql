/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (250) [Id]
      ,[ManufacturersId]
      ,[UniqueId]
      ,[Name]
      ,[ShortName]
      ,[LogoURI]
      ,[Notes]
      ,[IsActive]
      ,[WhoMod]
      ,[WhoAdded]
      ,[DateAdded]
      ,[DateMod]
      ,[Summary]
  FROM [RVResearch].[rvs].[Brands]

SELECT TOP (250) 
	'new Brands() { ManufacturersId = ' + CONVERT(varchar(100), ManufacturersId)
	+ ', ShortName = "' + ShortName + '"'
	+ ', Id = ' + CONVERT(varchar(100), Id) + ', IsActive = true, ' + ' UniqueId = new Guid("' + CONVERT(varchar(100), UniqueId) + '")'
	+ ', Name = "' + [Name] + '", Notes = "' + CONCAT('', Notes)
	-- + '", Summary = "' + CONCAT(Summary, '')
    + '", WhoAdded = 1, WhoMod = 1, DateAdded = DateTime.Now' + ', DateMod = DateTime.Now },' 
FROM [RVResearch].[rvs].[Brands]
WHERE Id IN (586,532,554,581,116)
