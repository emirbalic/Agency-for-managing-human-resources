
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_RadniciInsert]
(
@Ime NVARCHAR (50),
@Prezime NVARCHAR (50),
@JMBG NVARCHAR (50),
@UlicaIBroj NVARCHAR (50),
@MjestoId INT,
@Email NVARCHAR (50),
@Telefon NVARCHAR (20),
@StrukaId INT,
@SkolskaSpremaId INT,
@CijenaPoSatu DECIMAL (5,2)
)
AS
	DECLARE @AdresaID INT
	INSERT INTO Adrese (UlicaIBroj)
	VALUES (@UlicaIBroj)
	SELECT @AdresaID = @@IDENTITY

	DECLARE @OsobaID INT
	INSERT INTO Osobe (Ime, Prezime, JMBG, AdresaID, MjestoID, Email, Telefon)
	VALUES (@Ime, @Prezime, @JMBG, @AdresaID, @MjestoID, @Email, @Telefon)
	SELECT @OsobaID = @@IDENTITY

	INSERT INTO Radnici(OsobaID, StrukaId, SkolskaSpremaId, CijenaPoSatu, Status, DatumPrveRegistracije)
	VALUES (@OsobaID, @StrukaId, @SkolskaSpremaId, @CijenaPoSatu, 1, GETDATE())

GO
