SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_xrp_RezervacijeUPeriodu]
(
	@DatumPocetka	DATETIME,
	@DatumZavrsetka	DATETIME
)
AS
    SELECT SUM(R.RezervacijaId) AS BrojRezervacija, SUM(SR.BrojRadnihSati) AS BrojRadnihSati, SR.DatumRezervacije
	FROM Rezervacija AS R INNER JOIN StavkeRezervacije AS SR 
		 ON R.StavkeRezervacijeId=SR.StavkeRezervacijeId
		 WHERE SR.DatumRezervacije BETWEEN  @DatumPocetka AND @DatumZavrsetka 
		 GROUP BY SR.DatumRezervacije
		 ORDER BY SR.DatumRezervacije ASC
GO
