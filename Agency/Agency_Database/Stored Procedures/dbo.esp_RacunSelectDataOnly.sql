
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_RacunSelectDataOnly]
(
     @RadnikID INT,
     @RezervacijaID INT
)
AS
    SELECT O.Prezime + ' ' + O.Ime AS [Puno ime], S.Naziv AS [Struka], SS.Naziv AS [Stručna sprema], R.CijenaPoSatu, SR.DatumRezervacije,
	SR.DatumPocetka, SR.DatumZavrsetka, SR.BrojRadnihSati, K.Naziv AS [Naziv Firme], TA.Naziv AS [Tip_aktivnosti]

	FROM Radnici AS R JOIN StavkeRezervacije AS SR ON R.RadnikID = SR.RadnikID
		 JOIN Rezervacija AS RZ ON RZ.StavkeRezervacijeID = SR.StavkeRezervacijeID
		 JOIN Klijenti AS K ON RZ.KlijentID = K.KlijentID
		 JOIN Osobe AS O ON O.OsobaID = R.OsobaID
		 JOIN Struka AS S ON R.StrukaId = S.StrukaId
		 JOIN SkolskaSprema AS SS ON R.SkolskaSpremaId = SS.SkolskaSpremaId
		 JOIN TipAktivnosti AS TA ON TA.TipAktivnostiId = K.TipAktivnostiId

	WHERE R.RadnikID = @RadnikID AND RZ.RezervacijaID = RZ.RezervacijaID
	ORDER BY O.Prezime ASC
GO
