SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_RadniciOsobeSelectById_ToUpdate]
(
	@RadnikId	INT
)
AS
    SELECT R.RadnikId, O.OsobaId, O.Prezime, O.Ime, O.Email, O.Telefon,   
	R.CijenaPoSatu, R.Status
	FROM Radnici AS R JOIN Osobe AS O
	ON R.OsobaId = O.OsobaId
	WHERE R.RadnikId = @RadnikId
	ORDER BY O.Prezime
GO
