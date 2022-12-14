
SELECT TOP (250) [Id]
      ,[UniqueId]
      ,[Name]
      ,[ShortName]
      ,[Summary]
      ,[Notes]
      ,[CategoryId]
      ,[IsActive]
      ,[WhoMod]
      ,[WhoAdded]
      ,[DateAdded]
      ,[DateMod]
  FROM [RVResearch].[rvs].[TopTenItems]

  SELECT TOP (250) 
	'new TopTenItems() { DateAdded = DateTime.Now' + ', DateMod = DateTime.Now' 
	+ ', Id = ' + CONVERT(varchar(100), Id) 
	+ ', UniqueId = new Guid("' + CONVERT(varchar(100), UniqueId) + '")'
	+ ', Name = "' + [Name] + '"'
	+ ', ShortName = "' + ShortName + '"' 
	+ ', Summary = "' + CONCAT(Summary, '') + '"'
	+ ', Notes = "' + CONCAT('', Notes) + '"'
	+ ', CategoryId = ' + CONVERT(varchar(100), CategoryId)
	+ ', IsActive = true' 
    + ', WhoAdded = 1, WhoMod = 1 },' 
FROM [RVResearch].[rvs].[TopTenItems]

