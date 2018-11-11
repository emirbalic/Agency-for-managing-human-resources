
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_KlijentiResetPass]
(
	@Naziv NVARCHAR (50),
	@LozinkaSalt NVARCHAR (50),
	@LozinkaHash NVARCHAR (50)
)
AS
    UPDATE Klijenti
	SET
	LozinkaSalt = @LozinkaSalt,
	LozinkaHash = @LozinkaHash
	 WHERE Naziv = @Naziv
GO
