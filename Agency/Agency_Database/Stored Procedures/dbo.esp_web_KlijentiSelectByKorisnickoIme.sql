SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_web_KlijentiSelectByKorisnickoIme]
(
@KorisnickoIme NVARCHAR (50)
)
AS
    SELECT *
	FROM Klijenti
	WHERE KorisnickoIme = @KorisnickoIme
GO
