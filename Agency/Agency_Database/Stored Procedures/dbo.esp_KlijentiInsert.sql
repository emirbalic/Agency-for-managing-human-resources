
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_KlijentiInsert]
(
@Naziv NVARCHAR (50),
@Telefon NCHAR (20),
@Email NVARCHAR (50),
@UlicaIBroj NVARCHAR (50),
@MjestoID INT,
@TipAktivnostiId INT,
@KorisnickoIme NVARCHAR (50),
@LozinkaSalt NVARCHAR (50),
@LozinkaHash NVARCHAR (50)
)
AS
	DECLARE @AdresaID INT
	INSERT INTO Adrese (UlicaIBroj)
	VALUES (@UlicaIBroj)
	SELECT @AdresaID = @@IDENTITY


	INSERT INTO Klijenti(Naziv, Telefon, Email, AdresaId, MjestoId, TipAktivnostiId, KorisnickoIme, LozinkaSalt, LozinkaHash)
	VALUES (@Naziv, @Telefon, @Email, @AdresaID, @MjestoID, @TipAktivnostiId, @KorisnickoIme, @LozinkaSalt, @LozinkaHash)









GO
