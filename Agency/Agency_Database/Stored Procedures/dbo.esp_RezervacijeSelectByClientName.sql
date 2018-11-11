SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
create PROCEDURE [dbo].[esp_RezervacijeSelectByClientName]
(
	    @Naziv  NVARCHAR(50)
)
AS
	SELECT R.RezervacijaId, K.Naziv AS [Klijent], SR.DatumRezervacije, O.Ime + O.Prezime AS [Ime i prezime], 
	SR.BrojRadnihSati, RA.CijenaPoSatu 
	FROM Klijenti AS K 
	JOIN Rezervacija AS R ON K.KlijentId = R.KlijentId
	JOIN StavkeRezervacije AS SR ON R.StavkeRezervacijeId =SR.StavkeRezervacijeId
	JOIN Radnici AS RA ON RA.RadnikId = SR.RadnikId 
	JOIN Osobe AS O ON RA.OsobaId = O.OsobaId
	WHERE K.Naziv = @Naziv

GO
