SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_KorisniciSelectById]
(
	@KorisnikID INT
)
AS
	SELECT *
	FROM Korisnici
	WHERE KorisnikID = @KorisnikID
GO
