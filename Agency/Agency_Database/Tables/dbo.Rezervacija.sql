CREATE TABLE [dbo].[Rezervacija]
(
[RezervacijaId] [int] NOT NULL IDENTITY(1, 1),
[KlijentId] [int] NOT NULL,
[StavkeRezervacijeId] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Rezervacija] ADD CONSTRAINT [PK_Rezervacija] PRIMARY KEY CLUSTERED  ([RezervacijaId]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Rezervacija] ADD CONSTRAINT [FK_Rezervacija_Klijenti] FOREIGN KEY ([KlijentId]) REFERENCES [dbo].[Klijenti] ([KlijentId])
GO
ALTER TABLE [dbo].[Rezervacija] ADD CONSTRAINT [FK_Rezervacija_StavkeRezervacije] FOREIGN KEY ([StavkeRezervacijeId]) REFERENCES [dbo].[StavkeRezervacije] ([StavkeRezervacijeId])
GO
