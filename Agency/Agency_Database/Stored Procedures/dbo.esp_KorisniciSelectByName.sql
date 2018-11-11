SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_KorisniciSelectByName]
(
	@ImeIPrezime NVARCHAR (100)
)
AS
    SELECT O.OsobaID, K.KorisnikID, O.Prezime, O.Ime, O.Email, O.Telefon, K.StatusNaSistemu, COUNT(KU.KorisnikUlogaID) AS
	BrojUloga
	FROM Osobe AS O JOIN Korisnici AS K
	ON O.OsobaID = K.OsobaID 
	JOIN KorisniciUloge AS KU
	ON K.KorisnikID = KU.KorisnikID
	WHERE LOWER (Ime + ' ' + Prezime) LIKE LOWER (@ImeIPrezime) + '%' OR
	      LOWER (Prezime + ' ' + Ime) LIKE LOWER (@ImeIPrezime) + '%'
	GROUP BY O.OsobaID, K.KorisnikID, O.Ime, O.Prezime, O.Email, O.Telefon, K.StatusNaSistemu
	ORDER BY O.Prezime
GO
