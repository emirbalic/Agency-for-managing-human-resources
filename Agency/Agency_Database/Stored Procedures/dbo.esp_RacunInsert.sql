SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_RacunInsert]
(
	@Iznos	INT,
	@RezervacijaId	INT
)
AS
	INSERT INTO Racuni (Iznos, RezervacijaId, DatumIspostaveRacuna)
	VALUES (@Iznos, @RezervacijaId, GETDATE())
	SELECT @@IDENTITY
GO
