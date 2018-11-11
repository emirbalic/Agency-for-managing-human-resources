
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_xrp_Racun_SelectByClientId]
(
	@KlijentId	INT
)
AS
    SELECT R.RezervacijaId, K.Naziv, SR.DatumRezervacije, SR.DatumPocetka, SR.BrojRadnihSati, RD.CijenaPoSatu, O.Ime, O.Prezime  
	FROM Rezervacija AS R JOIN Klijenti AS K ON R.KlijentId = K.KlijentId
		 JOIN StavkeRezervacije AS SR ON SR.StavkeRezervacijeId = R.StavkeRezervacijeId
		 JOIN Radnici AS RD ON SR.RadnikId = RD.RadnikId
		 JOIN Osobe AS O ON RD.OsobaId = O.OsobaId 
    WHERE K.KlijentId = @KlijentId
	ORDER BY SR.DatumRezervacije
GO
