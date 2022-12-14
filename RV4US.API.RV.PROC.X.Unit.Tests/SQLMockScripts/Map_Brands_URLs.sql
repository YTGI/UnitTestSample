SELECT TOP (250) [BrandsId]
      ,[URLsId]
  FROM [RVResearch].[rvs].[Map_Brands_URLs]

SELECT TOP (250) 
	'new Map_Brands_URLs() { ' 
	+ 'BrandsId = ' + CONVERT(varchar(100), BrandsId) 
	+ ', URLsId = ' + CONVERT(varchar(100), URLsId)
	+ ' },' 
FROM [RVResearch].[rvs].[Map_Brands_URLs]

SELECT *
  FROM [RVResearch].[rvs].[Map_Brands_URLs] mbu
	JOIN rvs.URLs u ON u.Id = mbu.URLsId
  WHERE BrandsId = 36
