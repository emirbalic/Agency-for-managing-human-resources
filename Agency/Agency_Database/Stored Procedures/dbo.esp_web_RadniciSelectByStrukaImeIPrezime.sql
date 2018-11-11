
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_web_RadniciSelectByStrukaImeIPrezime]
(
	@StrukaId INT,
	@ImeIPrezime NVARCHAR (100),
	@Offset INT,
	@MaxRows INT,
	@TotalRows  INT OUTPUT
)
AS

	CREATE TABLE #TempTable
	(
		RedniBroj INT IDENTITY (0,1),
		RadnikID INT
	)
	INSERT INTO #TempTable
	SELECT DISTINCT RadnikID 
	FROM Radnici AS R INNER JOIN Osobe AS O ON R.OsobaId = R.OsobaId
	WHERE ((R.StrukaId = @StrukaId OR @StrukaId = 0) AND R.Status = 1) 
		  	
	SELECT @TotalRows = @@ROWCOUNT

	SELECT DISTINCT R.RadnikID, O.Prezime + ' ' + O.Ime AS [Prezime i ime], S.Naziv AS [Struka], SS.Naziv AS [Strucna sprema], R.CijenaPoSatu
	FROM Radnici AS R 
	INNER JOIN Osobe AS O ON R.OsobaID= O.OsobaID
	JOIN Struka AS S ON R.StrukaId = S.StrukaId
	JOIN SkolskaSprema AS SS ON R.SkolskaSpremaId = SS.SkolskaSpremaId
	JOIN #TempTable AS T ON R.RadnikID=T.RadnikID
	WHERE T.RedniBroj BETWEEN @Offset AND (@Offset + @MaxRows - 1) AND 
		  ((LOWER (O.Ime + ' ' + O.Prezime) LIKE LOWER (@ImeIPrezime) + '%') OR
	   	  (LOWER (O.Prezime + ' ' + O.Ime) LIKE LOWER (@ImeIPrezime)+ '%') OR
				@ImeIPrezime = '')
	ORDER BY [Prezime i ime]
	
	DROP TABLE #Temptable

GO
