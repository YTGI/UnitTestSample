
SELECT TOP (250) [Id]
      ,[LuCatId]
      ,[LuCode]
      ,[LuItemDesc]
      ,[EnumValue]
      ,[LuValue]
      ,[LuValue2]
      ,[IsActive]
      ,[LuBoolean]
      ,[LuQuantity]
      ,[LuDate1]
      ,[LuDate2]
      ,[WhoMod],[WhoAdd],[DateAdded],[DateMod]
  FROM [RVResearch].[lookups].[LuItems]

  SELECT 
	'new LuItems() { DateAdded = DateTime.Now' + ', DateMod = DateTime.Now' 
	+ ', Id = ' + CONVERT(varchar(100), Id) 
	+ ', LuCatId = ' + CONVERT(varchar(100), LuCatId) 
	+ ', LuCode = "' + LuCode + '"'
	+ ', LuItemDesc = "' + LuItemDesc + '"'
	+ ', EnumValue = ' + CONVERT(varchar(100), EnumValue) 
	+ ', LuValue = "' + CONCAT(LuValue,'') + '"'
	+ ', LuValue2 = "' + CONCAT(LuValue2,'') + '"'
    + ', LuBoolean = false' 
	+ ', LuQuantity = ' + CONVERT(varchar(100), LuQuantity) 
    + ', WhoAdd = "1", WhoMod = "1"' 
	+ ', IsActive = true },' 
FROM [RVResearch].[lookups].[LuItems]
