/*������ ������*/

CREATE OR ALTER PROCEDURE KInsuranceTestTaskFirst
AS
	SELECT 
		 medOrg.Code AS '���. ����������� (���)'
		,medOrg.NameShort AS '���. ����������� (������������)'
		,payInfo.MonthCode AS '�����'
		,payInfo.YearCode AS '���'
		,SUM(payInfo.Summ) AS '����� ���.'
	FROM rfcLPU AS medOrg
	INNER JOIN finConsolidatedMaster AS payInfo ON
		payInfo.LPUUrRef = medOrg.ID
	GROUP BY
		 medOrg.Code 
		,medOrg.NameShort 
		,payInfo.MonthCode
		,payInfo.YearCode
	ORDER BY 
		 medOrg.Code
		,payInfo.MonthCode
		,payInfo.YearCode
GO