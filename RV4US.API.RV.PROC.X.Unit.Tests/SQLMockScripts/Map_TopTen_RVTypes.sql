
SELECT TOP (250) [TopTenId]
      ,[RVTypeId]
  FROM [RVResearch].[rvs].[Map_TopTen_RVTypes]

SELECT 
	'new Map_TopTen_RVTypes() { '
	+ 'TopTenId = ' + CONVERT(varchar(100), ISNULL(TopTenId, 0))
	+ ', RVTypeId = ' + CONVERT(varchar(100), ISNULL(RVTypeId, 0))
	+ ' },' 
  FROM [RVResearch].[rvs].[Map_TopTen_RVTypes]

