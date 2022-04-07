﻿CREATE PROCEDURE FI_SP_VerificaBeneficiario
	@CPF VARCHAR(15),
	@IDCLIENTE  INT
AS
BEGIN
	SELECT 1 FROM BENEFICIARIOS WHERE CPF = @CPF AND IDCLIENTE = @IDCLIENTE
END

--DROP PROCEDURE [FI_SP_VerificaBeneficiario];  
--GO 