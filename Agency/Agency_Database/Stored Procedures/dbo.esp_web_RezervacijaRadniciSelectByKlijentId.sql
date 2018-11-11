SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_web_RezervacijaRadniciSelectByKlijentId]
(
	@KlijentId	INT
)
AS
    SELECT R.RezervacijaId, O.Prezime, O.Ime, SR.DatumRezervacije, SR.DatumPocetka, SR.DatumZavrsetka, SR.BrojRadnihSati 
	FROM Klijenti AS K JOIN Rezervacija AS R ON K.KlijentId = R.KlijentId
		 JOIN StavkeRezervacije AS SR ON R.StavkeRezervacijeId = SR.StavkeRezervacijeId
		 JOIN Radnici AS RD ON SR.RadnikId = RD.RadnikId
		 JOIN Osobe AS O ON RD.OsobaId = O.OsobaId
		 WHERE K.KlijentId = @KlijentId
		 ORDER BY O.Prezime
GO
