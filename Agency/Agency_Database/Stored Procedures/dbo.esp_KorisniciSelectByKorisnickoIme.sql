SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_KorisniciSelectByKorisnickoIme]
(
@KorisnickoIme NVARCHAR (50)
)
AS
    SELECT *
	FROM Korisnici
	WHERE KorisnickoIme = @KorisnickoIme AND StatusNaSistemu = 1;

GO
