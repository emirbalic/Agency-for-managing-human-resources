SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_web_RadniciSelectByStruka]
(
	@StrukaId INT,
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
	SELECT RadnikID 
	FROM Radnici AS R JOIN Osobe AS O ON R.OsobaId = O.OsobaId
	WHERE (StrukaId = @StrukaId OR @StrukaId = 0) AND
		  Status = 1
		  ORDER BY (O.Prezime)
	
	SELECT @TotalRows = @@ROWCOUNT

	SELECT R.RadnikID, O.Prezime + ' ' + O.Ime AS [Prezime i ime], S.Naziv AS [Struka], SS.Naziv AS [Strucna sprema], R.CijenaPoSatu
	FROM Radnici AS R 
	JOIN Osobe AS O ON R.OsobaID= O.OsobaID
	JOIN Struka AS S ON R.StrukaId = S.StrukaId
	JOIN SkolskaSprema AS SS ON R.SkolskaSpremaId = SS.SkolskaSpremaId
	INNER JOIN #TempTable AS T ON R.RadnikID=T.RadnikID
	WHERE T.RedniBroj BETWEEN @Offset AND (@Offset + @MaxRows - 1) 

	DROP TABLE #Temptable
GO
