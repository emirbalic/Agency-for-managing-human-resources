
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_KorisniciInsert]
(
@Ime NVARCHAR (50),
@Prezime NVARCHAR (50),
@Email NVARCHAR (50),
@Telefon NVARCHAR (20),
@KorisnickoIme NVARCHAR (50),
@LozinkaSalt NVARCHAR (50),
@LozinkaHash NVARCHAR (50),
@MjestoId  INT,
@UlicaIBroj  NVARCHAR(50)
)
AS
IF (NOT EXISTS(SELECT K.KorisnickoIme FROM Korisnici AS K WHERE K.KorisnickoIme = @KorisnickoIme))
BEGIN 
 
	DECLARE @AdresaId INT
	INSERT INTO Adrese(UlicaIBroj)
	VALUES (@UlicaIBroj)
	SELECT @AdresaId = @@IDENTITY

	DECLARE @OsobaId INT
	INSERT INTO Osobe (Ime, Prezime, AdresaId, MjestoId, Email, Telefon)
	VALUES (@Ime, @Prezime, @AdresaId, @MjestoId, @Email, @Telefon)
	SELECT @OsobaId = @@IDENTITY

	INSERT INTO Korisnici (OsobaId, KorisnickoIme, StatusNaSistemu, LozinkaSalt, LozinkaHash)
	VALUES (@OsobaID, @KorisnickoIme, 1, @LozinkaSalt, @LozinkaHash)
	SELECT @@IDENTITY
END


GO
