SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_StrukaInsert]
(
	@Naziv	NVARCHAR(50)
)
AS
    INSERT INTO Struka (Naziv)
	VALUES(@Naziv)
GO
