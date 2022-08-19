/*������ ������*/

CREATE OR ALTER PROCEDURE KInsuranceTestTaskThird
AS
	SELECT 
		 helpTypes.Code AS '��� ������ (���)'
		,helpTypes.Name AS '��� ������ (������������)'
		,ISNULL(
			 COUNT(IIF(volType.name like '%�����%',1,null))
			,0
		) as '���������� ���������' 
		,ISNULL(
			 COUNT(IIF(volType.name like '%�����%',1,null))
			,0
		) as '���������� ���������'
		,SUM(payInfo.CountSch) AS '���������� ������'
		,SUM(payInfo.Summ) AS '�����'
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