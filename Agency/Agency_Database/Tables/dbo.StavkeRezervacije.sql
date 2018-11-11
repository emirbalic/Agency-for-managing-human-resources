CREATE TABLE [dbo].[StavkeRezervacije]
(
[StavkeRezervacijeId] [int] NOT NULL IDENTITY(1, 1),
[RadnikId] [int] NOT NULL,
[DatumRezervacije] [datetime] NULL,
[DatumPocetka] [datetime] NULL,
[DatumZavrsetka] [datetime] NULL,
[StatusRezervacije] [bit] NULL,
[BrojRadnihSati] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[StavkeRezervacije] ADD CONSTRAINT [PK_StavkeRezervacije] PRIMARY KEY CLUSTERED  ([StavkeRezervacijeId]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[StavkeRezervacije] ADD CONSTRAINT [FK_StavkeRezervacije_Radnici] FOREIGN KEY ([RadnikId]) REFERENCES [dbo].[Radnici] ([RadnikId])
GO
