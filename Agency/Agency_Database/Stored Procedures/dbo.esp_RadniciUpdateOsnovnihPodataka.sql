SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[esp_RadniciUpdateOsnovnihPodataka]
(
	@OsobaId	INT,
	@RadnikId  INT,
	@Telefon NVARCHAR (20),
	@Email NVARCHAR (50),
	@CijenaPoSatu DECIMAL (5,2)
)
AS


    UPDATE Osobe
	SET
		Email = @Email,
		Telefon = @Telefon
	WHERE OsobaId = @OsobaId

	UPDATE Radnici
	SET
		CijenaPoSatu = @CijenaPoSatu
	WHERE RadnikId = @RadnikId
GO
