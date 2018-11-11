SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_OsobeSelectByKorisnikID]
(
	@KorisnikId INT
)
AS
    SELECT O.*
	FROM Korisnici AS K JOIN Osobe AS O
	ON K.OsobaID = O.OsobaID
	WHERE K.KorisnikID = @KorisnikId
GO
