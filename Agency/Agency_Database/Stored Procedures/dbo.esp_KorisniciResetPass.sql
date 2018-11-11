SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_KorisniciResetPass]
(
	@KorisnikID INT,
	@LozinkaSalt NVARCHAR (50),
	@LozinkaHash NVARCHAR (50)
)
AS
    UPDATE Korisnici
	SET
	LozinkaSalt = @LozinkaSalt,
	LozinkaHash = @LozinkaHash
	WHERE KorisnikID = @KorisnikID
GO
