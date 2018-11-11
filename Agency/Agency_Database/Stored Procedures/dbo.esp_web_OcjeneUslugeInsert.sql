SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_web_OcjeneUslugeInsert]
(
	@KlijentId INT,
	@RezervacijaId  INT,
	@Ocjena  INT,
	@Primjedba NVARCHAR(MAX),
	@Sugestije NVARCHAR(MAX)
)
AS
	INSERT INTO OcjenaUsluge (KlijentId, RezervacijaId, Ocjena, Primjedba, Sugestije)
	VALUES (@KlijentId, @RezervacijaId, @Ocjena, @Primjedba, @Sugestije)
GO
