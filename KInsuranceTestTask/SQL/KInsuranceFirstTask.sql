/*оЕПБЮЪ ГЮДЮВЮ*/

CREATE OR ALTER PROCEDURE KInsuranceTestTaskFirst
AS
	SELECT 
		 medOrg.Code AS 'лед. нпцюмхгюжхъ (йнд)'
		,medOrg.NameShort AS 'лед. нпцюмхгюжхъ (мюхлемнбюмхе)'
		,payInfo.MonthCode AS 'леяъж'
		,payInfo.YearCode AS 'цнд'
		,SUM(payInfo.Summ) AS 'ясллю пса.'
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