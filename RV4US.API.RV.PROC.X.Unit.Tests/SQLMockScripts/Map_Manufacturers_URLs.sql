SELECT TOP (250) [ManufacturersId]
      ,[URLsId]
  FROM [RVResearch].[rvs].[Map_Manufacturers_URLs]

SELECT TOP (250) 
	'new Map_Manufacturers_URLs() { ' 
	+ 'ManufacturersId = ' + CONVERT(varchar(100), ManufacturersId) 
	+ ', URLsId = ' + CONVERT(varchar(100), URLsId)
	+ ' },' 
FROM [RVResearch].[rvs].Map_Manufacturers_URLs

SELECT *
  FROM [RVResearch].[rvs].[Map_Manufacturers_URLs] mmu
	JOIN rvs.URLs u ON u.Id = mmu.URLsId
  WHERE ManufacturersId = 4
