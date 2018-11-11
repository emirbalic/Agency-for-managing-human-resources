SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_RadniciSelectByStrukaNaziv]
(
	@StrukaNaziv NVARCHAR(50)
)
AS
    SELECT O.OsobaID, R.RadnikID, O.Prezime, O.Ime, S.Naziv AS [Struka], SS.Naziv AS [Stručna sprema], O.Telefon, R.Status, R.DatumPrveRegistracije
	FROM Osobe AS O JOIN Radnici AS R 
	ON O.OsobaID = R.OsobaID
	JOIN Struka AS S 
	ON R.StrukaId = S.StrukaId
	JOIN SkolskaSprema AS SS
	ON R.SkolskaSpremaId = SS.SkolskaSpremaId
	WHERE s.Naziv = @StrukaNaziv  AND R.Status = 1
	ORDER BY O.Prezime
GO
