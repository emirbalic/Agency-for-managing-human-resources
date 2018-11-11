SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_KorisniciUlogeDelete]
(
	@KorisnikID INT
)
AS
	DELETE FROM 
	KorisniciUloge
	WHERE KorisnikID = @KorisnikID
GO
