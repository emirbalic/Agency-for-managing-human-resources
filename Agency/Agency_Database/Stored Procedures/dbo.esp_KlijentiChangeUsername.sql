
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_KlijentiChangeUsername]
(
	@Naziv NVARCHAR (50),
	@KorisnickoIme NVARCHAR(50)

)
AS
    UPDATE Klijenti
	SET
	KorisnickoIme = @KorisnickoIme
	WHERE Naziv = @Naziv
GO
