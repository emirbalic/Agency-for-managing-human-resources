SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_RacunSelectByRezervacijaId]
(
	@RezervacijaId   INT
)
AS
    SELECT K.Naziv AS [Klijent], R.Iznos, R.DatumIspostaveRacuna
	FROM Racuni AS R 
	JOIN Rezervacija AS RA ON R.RezervacijaId = RA.RezervacijaId
	JOIN Klijenti AS K ON RA.KlijentId = K.KlijentId
	WHERE RA.RezervacijaId = @RezervacijaId
GO
