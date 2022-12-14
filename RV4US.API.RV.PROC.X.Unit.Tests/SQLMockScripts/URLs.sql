/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (250) [Id]
      ,[UniqueId]
      ,[URLTypeId]
      ,[EntireURI]
      ,[IsActive]
      ,[WhoMod]
      ,[WhoAdded]
      ,[DateAdded]
      ,[DateMod]
  FROM [RVResearch].[rvs].[URLs]

SELECT TOP (250) 
	'new URLs() { DateAdded = DateTime.Now' + ', DateMod = DateTime.Now' 
	+ ', Id = ' + CONVERT(varchar(100), Id) 
	+ ', UniqueId = new Guid("' + CONVERT(varchar(100), UniqueId) + '")'
	+ ', URLTypeId = ' + CONVERT(varchar(100), URLTypeId)
	+ ', EntireURI = "' + CONCAT('', EntireURI) + '"'
	+ ', IsActive = true' 
    + ', WhoAdded = 1, WhoMod = 1 },' 
FROM [RVResearch].[rvs].[URLs]

