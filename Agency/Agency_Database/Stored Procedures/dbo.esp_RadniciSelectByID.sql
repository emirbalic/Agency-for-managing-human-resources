SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_RadniciSelectByID]
(
	@RadnikID INT
)
AS
    SELECT *
	FROM Radnici
	WHERE RadnikID = @RadnikID
GO
