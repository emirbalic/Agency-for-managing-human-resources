SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_SkolskaSpremaInsert]
(
	@Naziv	NVARCHAR(50)
)
AS
    INSERT INTO SkolskaSprema(Naziv)
	VALUES(@Naziv)
GO
