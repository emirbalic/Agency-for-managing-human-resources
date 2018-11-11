CREATE TABLE [dbo].[Racuni]
(
[RacunId] [int] NOT NULL IDENTITY(1, 1),
[Iznos] [decimal] (7, 2) NOT NULL,
[RezervacijaId] [int] NULL,
[DatumIspostaveRacuna] [date] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Racuni] ADD CONSTRAINT [PK_Racuni] PRIMARY KEY CLUSTERED  ([RacunId]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Racuni] ADD CONSTRAINT [FK_Racuni_Rezervacija] FOREIGN KEY ([RezervacijaId]) REFERENCES [dbo].[Rezervacija] ([RezervacijaId])
GO
