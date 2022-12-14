
SELECT TOP (250) [Id]
      ,[UniqueId]
      ,[BrandsId]
      ,[ModelYear]
      ,[ModelNumber]
      ,[Prefix]
      ,[Suffix]
      ,[PostSuffix]
      ,[Name]
      ,[ShortName]
      ,[LogoURI]
      ,[Notes]
      ,[Summary]
      ,[RVTypeId]
      ,[RVSubTypeId]
      ,[RVCategoryId]
      ,[IsActive]
      ,[WhoMod]
      ,[WhoAdded]
      ,[DateAdded]
      ,[DateMod]
  FROM [RVResearch].[rvs].[RVModels]

SELECT TOP (250) 
	'new RVModels() { BrandsId = ' + CONVERT(varchar(100), BrandsId)
	+ ', RVTypeId = ' + CONVERT(varchar(100), CONCAT(0, RVTypeId))
	+ ', RVSubTypeId = ' + CONVERT(varchar(100), CONCAT(0, RVSubTypeId))
	+ ', Id = ' + CONVERT(varchar(100), Id) + ', IsActive = true, ' + ' UniqueId = new Guid("' + CONVERT(varchar(100), UniqueId) + '")'
	+ ', RVCategoryId = ' + CONVERT(varchar(100), CONCAT(0, RVCategoryId))
	+ ', ModelYear = ' + CONVERT(varchar(100), ModelYear)
	+ ', ModelNumber = "' + CONCAT(ModelNumber,'') + '"'
	+ ', Prefix = "' + CONCAT(Prefix,'') + '"'
	+ ', Suffix = "' + CONCAT(Suffix,'') + '"'
	+ ', PostSuffix = "' + CONCAT(PostSuffix,'') + '"'
	+ ', Name = "' + [Name] + '", Notes = "' + CONCAT('', Notes) + '", ShortName = "' + ShortName + '", Summary = "' + CONCAT(Summary, '')
    + '", WhoAdded = 1, WhoMod = 1, DateAdded = DateTime.Now' + ', DateMod = DateTime.Now },' 
FROM [RVResearch].[rvs].[RVModels]
WHERE BrandsId IN (586,532,554,581,116)
