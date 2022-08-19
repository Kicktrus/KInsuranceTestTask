/*рПЕРЭЪ ГЮДЮВЮ*/

CREATE OR ALTER PROCEDURE KInsuranceTestTaskThird
AS
	SELECT 
		 helpTypes.Code AS 'бхд онлных (йнд)'
		,helpTypes.Name AS 'бхд онлных (мюхлемнбюмхе)'
		,ISNULL(
			 COUNT(IIF(volType.name like '%ОНЯЕЫ%',1,null))
			,0
		) as 'йнкхвеярбн оняеыемхи' 
		,ISNULL(
			 COUNT(IIF(volType.name like '%НАПЮЫ%',1,null))
			,0
		) as 'йнкхвеярбн напюыемхи'
		,SUM(payInfo.CountSch) AS 'йнкхвеярбн явернб'
		,SUM(payInfo.Summ) AS 'ясллю'
	FROM finConsolidatedMaster payInfo
	INNER JOIN rfcHelpForm AS helpTypes
		ON helpTypes.ID = payInfo.HelpFormRef
	LEFT JOIN finConsolidatedDetail volumeInfo
		ON volumeInfo.finConsolidatedMasterRef = payInfo.ID
	LEFT JOIN rfcVolume volType
		ON volType.ID = volumeInfo.VolumeRef
	GROUP BY
		 helpTypes.Code
		,helpTypes.Name
	ORDER BY 
		 helpTypes.Code
GO