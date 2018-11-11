SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_RacunSelectByClientId]
(
     @KlijentID INT, 
	 @RezervacijaId  INT
)
AS
    SELECT 
		K.Naziv AS [Naziv Firme],
		TA.Naziv AS [Tip_aktivnosti],
		O.Prezime + ' ' + O.Ime AS [Ime i prezime radnika], 
		S.Naziv AS [Struka], 
		SS.Naziv AS [Stručna sprema],
		RA.DatumIspostaveRacuna,
		SR.DatumRezervacije,
		SR.DatumPocetka, 
		SR.DatumZavrsetka, 
		SR.BrojRadnihSati, 
		R.CijenaPoSatu,
		RA.Iznos AS [Ukupan iznos računa]

	FROM Radnici AS R JOIN StavkeRezervacije AS SR ON R.RadnikID = SR.RadnikID
		 JOIN Rezervacija AS RZ ON RZ.StavkeRezervacijeID = SR.StavkeRezervacijeID
		 JOIN Klijenti AS K ON RZ.KlijentID = K.KlijentID
		 JOIN Osobe AS O ON O.OsobaID = R.OsobaID
		 JOIN Struka AS S ON R.StrukaId = S.StrukaId
		 JOIN SkolskaSprema AS SS ON R.SkolskaSpremaId = SS.SkolskaSpremaId
		 JOIN TipAktivnosti AS TA ON TA.TipAktivnostiId = K.TipAktivnostiId
		 JOIN Racuni AS RA ON RA.RezervacijaId = RZ.RezervacijaId

	WHERE K.KlijentId = @KlijentID AND RA.RezervacijaId = @RezervacijaId
	ORDER BY RA.DatumIspostaveRacuna ASC
GO
