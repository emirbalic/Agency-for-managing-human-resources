SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_RezervacijaCreate]
(
	@KlijentId	INT,
	@RadnikId	INT,
	@DatumRezervacije DATETIME,
	@DatumPocetka	DATETIME,
	@DatumZavrsetka DATETIME,
	@BrojRadnihSati	 INT
)
AS
	DECLARE @StavkeRezervacijeId INT
	INSERT INTO StavkeRezervacije (RadnikId, DatumRezervacije, DatumPocetka, DatumZavrsetka, StatusRezervacije,
	BrojRadnihSati)
	VALUES (@RadnikId, @DatumRezervacije, @DatumPocetka, @DatumZavrsetka, 1, @BrojRadnihSati)
	SELECT @StavkeRezervacijeID = @@IDENTITY

	INSERT INTO Rezervacija (KlijentId, StavkeRezervacijeId)
	VALUES (@KlijentId, @StavkeRezervacijeId)
GO
