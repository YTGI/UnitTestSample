
SELECT TOP (250) [RVModelsId]
      ,[URLsId]
  FROM [RVResearch].[rvs].[Map_RVModels_URLs]

SELECT TOP (250) 
	'new Map_RVModels_URLs() { ' 
	+ 'RVModelsId = ' + CONVERT(varchar(100), RVModelsId) 
	+ ', URLsId = ' + CONVERT(varchar(100), URLsId)
	+ ' },' 
FROM [RVResearch].[rvs].[Map_RVModels_URLs]

SELECT *
  FROM [RVResearch].[rvs].[Map_RVModels_URLs] mru
	JOIN rvs.URLs u ON u.Id = mru.URLsId
  WHERE RVModelsId = 4
