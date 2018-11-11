
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_RezervacijeCancelByRadnikId]
(
@RadnikId	INT,
@DatumRezervacije	DATETIME
)
AS
    UPDATE StavkeRezervacije 
	SET StatusRezervacije = 0
	WHERE RadnikId = @RadnikId AND DatumRezervacije = @DatumRezervacije
GO
