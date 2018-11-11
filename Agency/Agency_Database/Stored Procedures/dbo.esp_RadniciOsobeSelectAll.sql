
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_RadniciOsobeSelectAll]
(
	@RadnikId INT
)

AS
    SELECT R.RadnikId, O.OsobaId, O.Prezime, O.Ime, O.JMBG, O.Email, O.Telefon, S.Naziv AS [Struka], SS.Naziv AS [Stručna sprema],  
	R.CijenaPoSatu, R.Status, R.DatumPrveRegistracije
	FROM Radnici AS R JOIN Osobe AS O
	ON R.OsobaId=O.OsobaId JOIN Adrese AS A
	ON O.AdresaId = A.AdresaId JOIN Mjesta AS M
	ON O.MjestoId = M.MjestoId JOIN Struka AS S
	ON R.StrukaId = S.StrukaId JOIN SkolskaSprema AS SS
	ON R.SkolskaSpremaId = SS.SkolskaSpremaId
	WHERE RadnikId = @RadnikId
	ORDER BY O.Prezime
GO
