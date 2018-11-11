SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_TipAktivnostiSelectAll]
AS
    SELECT *
	FROM TipAktivnosti
	ORDER BY Naziv








GO
