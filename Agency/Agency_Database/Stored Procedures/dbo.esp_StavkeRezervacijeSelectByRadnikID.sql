
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_StavkeRezervacijeSelectByRadnikID]
(
	@RadnikID INT
)
AS
    SELECT *
	FROM StavkeRezervacije
	WHERE RadnikID = @RadnikID AND StatusRezervacije = 1
GO
