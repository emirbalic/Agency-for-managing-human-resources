CREATE TABLE [dbo].[Klijenti]
(
[KlijentId] [int] NOT NULL IDENTITY(1, 1),
[Naziv] [nvarchar] (50) COLLATE Latin1_General_CI_AI NOT NULL,
[Telefon] [nchar] (20) COLLATE Latin1_General_CI_AI NULL,
[Email] [nvarchar] (50) COLLATE Latin1_General_CI_AI NULL,
[AdresaId] [int] NOT NULL,
[MjestoId] [int] NOT NULL,
[TipAktivnostiId] [int] NOT NULL,
[KorisnickoIme] [nvarchar] (50) COLLATE Latin1_General_CI_AI NULL,
[LozinkaSalt] [nvarchar] (50) COLLATE Latin1_General_CI_AI NULL,
[LozinkaHash] [nvarchar] (50) COLLATE Latin1_General_CI_AI NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Klijenti] ADD CONSTRAINT [CS_EmailKlijenti] UNIQUE NONCLUSTERED  ([Email]) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Klijenti] ADD CONSTRAINT [CS_KorisnickoImeKlijenti] UNIQUE NONCLUSTERED  ([KorisnickoIme]) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Klijenti] ADD CONSTRAINT [PK_Klijenti] PRIMARY KEY CLUSTERED  ([KlijentId]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Klijenti] ADD CONSTRAINT [FK_Klijenti_Adrese] FOREIGN KEY ([AdresaId]) REFERENCES [dbo].[Adrese] ([AdresaId])
GO
ALTER TABLE [dbo].[Klijenti] ADD CONSTRAINT [FK_Klijenti_Mjesta] FOREIGN KEY ([MjestoId]) REFERENCES [dbo].[Mjesta] ([MjestoId])
GO
ALTER TABLE [dbo].[Klijenti] ADD CONSTRAINT [FK_Klijenti_TipAktivnosti] FOREIGN KEY ([TipAktivnostiId]) REFERENCES [dbo].[TipAktivnosti] ([TipAktivnostiId])
GO
