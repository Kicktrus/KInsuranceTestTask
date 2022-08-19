/*бРНПЮЪ ГЮДЮВЮ*/

CREATE OR ALTER PROCEDURE KInsuranceTestTaskSecond
AS
	SELECT 
		 medType.Code AS 'лед. нпцюмхгюжхъ (йнд)'
		,medType.NameShort AS 'лед. нпцюмхгюжхъ (мюхлемнбюмхе)'
		,payType.Code AS 'рхо нокюрш (йнд)'
		,payType.NameShort AS 'рхо нокюрш (мюхлемнбюмхе)'
		,SUM(payInfo.CountSch) AS 'йнкхвеярбн явернб'
		,SUM(payInfo.Summ) AS 'ясллю пса.'
	FROM finConsolidatedMaster AS payInfo
	INNER JOIN rfcTypePayment AS payType ON
		payType.Id = payInfo.TypePaymentRef
	INNER JOIN rfcLPU AS medType ON
		medType.Id = payInfo.LPUUrRef
	GROUP BY
		 medType.Code
		,medType.NameShort
		,payType.Code
		,payType.NameShort
	ORDER BY 
		 medType.Code
		,payType.Code
GO