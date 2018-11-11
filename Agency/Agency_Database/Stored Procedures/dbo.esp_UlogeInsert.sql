SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_UlogeInsert]
(
	@Naziv NVARCHAR(50)
)

AS
    INSERT INTO Uloge(Naziv)
	VALUES (@Naziv)
GO
