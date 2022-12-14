SELECT TOP (250) [Id]
      ,[ShortName]
      ,[Name]
      ,[Description]
      ,[WhoMod]
      ,[WhoAdd]
      ,[DateAdded]
      ,[DateMod]
      ,[IsActive]
  FROM [RVResearch].[lookups].[LuCategories]

SELECT 
	'new LuCategories() { DateAdded = DateTime.Now' + ', DateMod = DateTime.Now' 
	+ ', Id = ' + CONVERT(varchar(100), Id) 
	+ ', ShortName = "' + ShortName + '"'
	+ ', Name = "' + [Name] + '"'
	+ ', Description = "' + CONCAT([Description],'') + '"'
    + ', WhoAdd = "1", WhoMod = "1"' 
	+ ', IsActive = true },' 
FROM [RVResearch].[lookups].[LuCategories]
