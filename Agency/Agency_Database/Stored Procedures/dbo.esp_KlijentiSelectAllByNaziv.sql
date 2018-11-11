
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_KlijentiSelectAllByNaziv]
(
	@Naziv NVARCHAR (50)
)
AS
    SELECT K.Naziv AS Klijent, K.Telefon, K.Email, 
	TA.Naziv AS [Tip Aktivnosti], A.UlicaIBroj, M.Naziv AS Mjesto, D.Naziv AS [Država]
	FROM Klijenti AS K 
	JOIN Adrese AS A
	ON K.AdresaID = A.AdresaID
	JOIN Mjesta AS M 
	ON K.MjestoID = M.MjestoID
	JOIN Drzave AS D
	ON M.DrzavaID = D.DrzavaID 
	JOIN TipAktivnosti AS TA 
	ON K.TipAktivnostiId = TA.TipAktivnostiId	
	WHERE LOWER (K.Naziv) LIKE LOWER (@Naziv) + '%'
	ORDER BY K.Naziv

GO
