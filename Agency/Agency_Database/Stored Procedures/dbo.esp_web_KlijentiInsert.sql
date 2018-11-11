SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_web_KlijentiInsert]
(
@Naziv NVARCHAR (50),
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


	INSERT INTO Klijenti(Naziv, Email, AdresaId, MjestoId, TipAktivnostiId, KorisnickoIme, LozinkaSalt, LozinkaHash)
	VALUES (@Naziv, @Email, @AdresaID, @MjestoID, @TipAktivnostiId, @KorisnickoIme, @LozinkaSalt, @LozinkaHash)
GO
