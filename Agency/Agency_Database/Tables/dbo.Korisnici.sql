CREATE TABLE [dbo].[Korisnici]
(
[KorisnikId] [int] NOT NULL IDENTITY(1, 1),
[OsobaId] [int] NOT NULL,
[KorisnickoIme] [nvarchar] (50) COLLATE Latin1_General_CI_AI NOT NULL,
[StatusNaSistemu] [bit] NULL,
[LozinkaSalt] [nvarchar] (50) COLLATE Latin1_General_CI_AI NULL,
[LozinkaHash] [nvarchar] (50) COLLATE Latin1_General_CI_AI NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Korisnici] ADD CONSTRAINT [CS_KorisnickoIme] UNIQUE NONCLUSTERED  ([KorisnickoIme]) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Korisnici] ADD CONSTRAINT [PK_Korisnici] PRIMARY KEY CLUSTERED  ([KorisnikId]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Korisnici] ADD CONSTRAINT [FK_Korisnici_Osobe] FOREIGN KEY ([OsobaId]) REFERENCES [dbo].[Osobe] ([OsobaId])
GO
