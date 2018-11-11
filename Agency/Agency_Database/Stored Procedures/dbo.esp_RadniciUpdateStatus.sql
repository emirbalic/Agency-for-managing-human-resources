SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_RadniciUpdateStatus]
(
	@RadnikID INT,
	@Status BIT
)
AS
	UPDATE Radnici
	SET Status = @Status
	WHERE RadnikID = @RadnikID
GO
