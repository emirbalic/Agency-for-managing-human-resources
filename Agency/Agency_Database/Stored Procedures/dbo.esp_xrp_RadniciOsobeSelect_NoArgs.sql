SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_xrp_RadniciOsobeSelect_NoArgs]
AS
    SELECT R.RadnikId, (O.Prezime + ' ' + O.Ime) AS [Prezime_i_ime]
	FROM Radnici AS R JOIN Osobe AS O
	ON R.OsobaId=O.OsobaId 
	ORDER BY [Prezime_i_ime]
GO
