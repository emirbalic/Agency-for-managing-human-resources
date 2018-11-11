SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_KorisniciUlogeInsert]
(
@KorisnikId INT,
@UlogaId INT
)
AS
INSERT INTO KorisniciUloge(KorisnikId, UlogaId, DatumIzmjene)
VALUES (@KorisnikId, @UlogaId, GETDATE())

GO
