SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
create PROCEDURE [dbo].[esp_KlijentiUpdateLicnihPodataka]
(
	@Naziv NVARCHAR (50),
	@Telefon NVARCHAR (20),
	@Email NVARCHAR (50),
	@UlicaIBroj NVARCHAR (50),
	@MjestoId INT
)
AS

	DECLARE @AdresaId INT
	INSERT INTO Adrese (UlicaIBroj)
	VALUES (@UlicaIBroj)
	SELECT @AdresaId = @@IDENTITY

    UPDATE Klijenti
	SET
		Email = @Email,
		Telefon = @Telefon,
		AdresaId = @AdresaId,
		MjestoId = @MjestoId
	 WHERE Naziv = @Naziv
GO
