CREATE PROCEDURE FI_SP_PesqBeneficiario
	@IDCLIENTE INT
AS
BEGIN
	SELECT * FROM BENEFICIARIOS WHERE IDCLIENTE = @IDCLIENTE
END

--DROP PROCEDURE [FI_SP_PesqBeneficiario];  
--GO  