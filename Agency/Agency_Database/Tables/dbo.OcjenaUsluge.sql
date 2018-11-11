CREATE TABLE [dbo].[OcjenaUsluge]
(
[OcjenaUslugeId] [int] NOT NULL IDENTITY(1, 1),
[KlijentId] [int] NOT NULL,
[RezervacijaId] [int] NOT NULL,
[Ocjena] [int] NOT NULL,
[Primjedba] [nvarchar] (max) COLLATE Latin1_General_CI_AI NULL,
[Sugestije] [nvarchar] (max) COLLATE Latin1_General_CI_AI NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[OcjenaUsluge] ADD CONSTRAINT [PK_OcjenaUsluge] PRIMARY KEY CLUSTERED  ([OcjenaUslugeId]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[OcjenaUsluge] ADD CONSTRAINT [FK_OcjenaUsluge_Klijenti] FOREIGN KEY ([KlijentId]) REFERENCES [dbo].[Klijenti] ([KlijentId])
GO
ALTER TABLE [dbo].[OcjenaUsluge] ADD CONSTRAINT [FK_OcjenaUsluge_Rezervacija] FOREIGN KEY ([RezervacijaId]) REFERENCES [dbo].[Rezervacija] ([RezervacijaId])
GO
