SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_KorisniciUpdateStatus]
(
	@KorisnikID INT,
	@StatusNaSistemu BIT
)
AS
	UPDATE Korisnici
	SET StatusNaSistemu = @StatusNaSistemu
	WHERE KorisnikID = @KorisnikID
GO
