CREATE TABLE [dbo].[Radnici]
(
[RadnikId] [int] NOT NULL IDENTITY(1, 1),
[OsobaId] [int] NOT NULL,
[StrukaId] [int] NOT NULL,
[SkolskaSpremaId] [int] NOT NULL,
[CijenaPoSatu] [decimal] (5, 2) NULL,
[Status] [bit] NULL,
[DatumPrveRegistracije] [date] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Radnici] ADD CONSTRAINT [PK_Radnici] PRIMARY KEY CLUSTERED  ([RadnikId]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Radnici] ADD CONSTRAINT [FK_Radnici_Osobe] FOREIGN KEY ([OsobaId]) REFERENCES [dbo].[Osobe] ([OsobaId])
GO
ALTER TABLE [dbo].[Radnici] ADD CONSTRAINT [FK_Radnici_SkolskaSprema] FOREIGN KEY ([SkolskaSpremaId]) REFERENCES [dbo].[SkolskaSprema] ([SkolskaSpremaId])
GO
ALTER TABLE [dbo].[Radnici] ADD CONSTRAINT [FK_Radnici_Struka] FOREIGN KEY ([StrukaId]) REFERENCES [dbo].[Struka] ([StrukaId])
GO
