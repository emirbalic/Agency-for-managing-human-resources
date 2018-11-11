
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_OsobeUpdateLicnihPodataka]
(
	@OsobaId INT,
	@Ime NVARCHAR (50),
	@Prezime NVARCHAR (50),
	@Email NVARCHAR (50),
	@Telefon NVARCHAR (20),
	@UlicaIBroj NVARCHAR (50),
	@MjestoId INT
)
AS

	DECLARE @AdresaId INT
	INSERT INTO Adrese (UlicaIBroj)
	VALUES (@UlicaIBroj)
	SELECT @AdresaId = @@IDENTITY

    UPDATE Osobe
	SET
		Ime = @Ime,
		Prezime = @Prezime,
		Email = @Email,
		Telefon = @Telefon,
		AdresaId = @AdresaId,
		MjestoId = @MjestoId
	WHERE OsobaID = @OsobaId
GO
