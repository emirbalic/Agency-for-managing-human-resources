SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_RadniciSelectNamesOnly]
AS
    SELECT R.RadnikID, O.Prezime  +' ' + O.Ime  AS FULLNAME
	FROM Radnici AS R JOIN Osobe AS O ON R.OsobaID = O.OsobaID
	ORDER BY FULLNAME ASC
GO
