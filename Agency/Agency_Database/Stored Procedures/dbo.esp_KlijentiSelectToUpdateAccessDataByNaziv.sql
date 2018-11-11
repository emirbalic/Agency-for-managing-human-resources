
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_KlijentiSelectToUpdateAccessDataByNaziv]
(
	@Naziv NVARCHAR (50)
)
AS
	SELECT *
	FROM Klijenti
	WHERE Naziv = @Naziv
GO
