SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_SkolskaSpremaSelectAll]
AS
    SELECT *
	FROM SkolskaSprema
	ORDER BY 'Naziv'
GO
