SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_TipAktivnostiInsert]
(
	@Naziv  NVARCHAR(50)
)
AS
    INSERT INTO TipAktivnosti (Naziv)
	VALUES (@Naziv)
GO
