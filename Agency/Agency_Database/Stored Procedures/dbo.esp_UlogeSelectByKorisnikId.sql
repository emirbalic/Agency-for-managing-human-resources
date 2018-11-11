SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
	CREATE PROCEDURE [dbo].[esp_UlogeSelectByKorisnikId]
(
	@KorisnikId	INT
)
AS
	SELECT U.UlogaId, U.Naziv
	FROM Uloge AS U JOIN KorisniciUloge AS KU ON U.UlogaId=KU.UlogaId
	WHERE KU.KorisnikId = @KorisnikId
GO
