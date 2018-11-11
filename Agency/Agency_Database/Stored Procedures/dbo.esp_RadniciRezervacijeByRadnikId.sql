
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_RadniciRezervacijeByRadnikId]
(
	@RadnikId INT
)
AS
    SELECT RZ.RezervacijaID, O.Prezime + ' ' + O.Ime AS [Puno ime], ST.Naziv AS [Struka], SK.Naziv AS [Stručna_sprema], R.CijenaPoSatu, S.DatumRezervacije, S.BrojRadnihSati,
	K.Naziv AS [Naziv_firme], TA.Naziv AS [Tip_aktivnosti]
	FROM Radnici AS R JOIN StavkeRezervacije AS S
	ON R.RadnikID = S.RadnikID JOIN Rezervacija AS RZ
	ON S.StavkeRezervacijeID = RZ.StavkeRezervacijeID JOIN Osobe AS O
	ON R.OsobaID = O.OsobaID JOIN Klijenti AS K 
	ON RZ.KlijentID = K.KlijentID JOIN Struka AS ST
	ON R.StrukaId = ST.StrukaId JOIN SkolskaSprema SK
	ON R.SkolskaSpremaId = SK.SkolskaSpremaId JOIN TipAktivnosti AS TA
	ON K.TipAktivnostiId = TA.TipAktivnostiId
	
	WHERE R.RadnikID = @RadnikId AND S.StatusRezervacije = 1
	ORDER BY O.Prezime ASC
GO
