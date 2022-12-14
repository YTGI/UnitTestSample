/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (250) [Id]
      ,[UniqueId]
      ,[Name]
      ,[ShortName]
      ,[HomePageURL]
      ,[LogoURI]
      ,[Notes]
      ,[IsActive]
      ,[WhoMod]
      ,[WhoAdded]
      ,[DateAdded]
      ,[DateMod]
      ,[Summary]
  FROM [RVResearch].[rvs].[Manufacturers]

  SELECT TOP (250) 
	'new Manufacturers() { DateAdded = DateTime.Now' + ', DateMod = DateTime.Now' 
	+ ', Id = ' + CONVERT(varchar(100), Id) + ', IsActive = true, ' + ' UniqueId = new Guid("' + CONVERT(varchar(100), UniqueId) + '"), '
	+ 'Name = "' + [Name] + '", Notes = "' + CONCAT('', Notes) + '", ShortName = "' + ShortName + '", Summary = "' + CONCAT(Summary, '')
    + '", WhoAdded = 1, WhoMod = 1 },' 
FROM [RVResearch].[rvs].[Manufacturers]

