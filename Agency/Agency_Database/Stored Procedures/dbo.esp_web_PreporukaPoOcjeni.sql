SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_web_PreporukaPoOcjeni]

AS

    SELECT RD.RadnikID, O.Prezime + ' ' + O.Ime AS [Prezime i ime], S.Naziv AS [Struka], SS.Naziv AS [Strucna sprema], RD.CijenaPoSatu
	FROM OcjenaUsluge AS OU JOIN Rezervacija AS R ON OU.RezervacijaId = R.RezervacijaId
							JOIN StavkeRezervacije AS SR ON R.StavkeRezervacijeId = SR.StavkeRezervacijeId
							JOIN Radnici AS RD ON SR.RadnikId = RD.RadnikId
							JOIN Osobe AS O ON RD.OsobaId = O.OsobaId
							JOIN SkolskaSprema AS SS ON RD.SkolskaSpremaId = SS.SkolskaSpremaId
							JOIN Struka AS S ON RD.StrukaId = S.StrukaId
	WHERE OU.Ocjena >= 6

GO
