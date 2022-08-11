
SELECT TOP (250) [FeaturesBaseId]
      ,[RVTypeId]
  FROM [RVResearch].[rvs].[Map_Features_RVTypes]

SELECT 
	'new Map_Features_RVTypes() { '
	+ 'FeaturesBaseId = ' + CONVERT(varchar(100), ISNULL(FeaturesBaseId, 0))
	+ ', RVTypeId = ' + CONVERT(varchar(100), ISNULL(RVTypeId, 0))
	+ ' },' 
  FROM [RVResearch].[rvs].[Map_Features_RVTypes]

