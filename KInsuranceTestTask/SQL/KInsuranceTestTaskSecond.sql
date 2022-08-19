/*������ ������*/

CREATE OR ALTER PROCEDURE KInsuranceTestTaskSecond
AS
	SELECT 
		 medType.Code AS '���. ����������� (���)'
		,medType.NameShort AS '���. ����������� (������������)'
		,payType.Code AS '��� ������ (���)'
		,payType.NameShort AS '��� ������ (������������)'
		,SUM(payInfo.CountSch) AS '���������� ������'
		,SUM(payInfo.Summ) AS '����� ���.'
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