SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_KorisniciUlogeSelectByKorisnik]
(
	@KorisnikID INT
)
AS
SELECT U.*
	FROM KorisniciUloge AS KU JOIN Uloge AS U
	ON KU.UlogaID = U.UlogaID
	WHERE KU.KorisnikID = @KorisnikID
GO
