
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_RadniciOsobeSelectByName_ToUpdate]
(
	@ImeIPrezime  NVARCHAR(50)
)
AS
    SELECT R.RadnikId, O.OsobaId, O.Prezime, O.Ime, O.Email, O.Telefon,   
	R.CijenaPoSatu, R.Status
	FROM Radnici AS R JOIN Osobe AS O
	ON R.OsobaId = O.OsobaId
	WHERE LOWER(O.Ime + ' ' + O.Prezime) LIKE LOWER(@ImeIPrezime)  + '%' OR
	LOWER(O.Prezime + ' ' +  O.Ime)LIKE  LOWER(@ImeIPrezime)
	ORDER BY O.Prezime

GO
