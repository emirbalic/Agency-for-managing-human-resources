CREATE TABLE [dbo].[KorisniciUloge]
(
[KorisnikUlogaId] [int] NOT NULL IDENTITY(1, 1),
[KorisnikId] [int] NOT NULL,
[UlogaId] [int] NOT NULL,
[DatumIzmjene] [date] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[KorisniciUloge] ADD CONSTRAINT [PK_KorisniciUloge_1] PRIMARY KEY CLUSTERED  ([KorisnikUlogaId]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[KorisniciUloge] ADD CONSTRAINT [FK_KorisniciUloge_Korisnici] FOREIGN KEY ([KorisnikId]) REFERENCES [dbo].[Korisnici] ([KorisnikId])
GO
ALTER TABLE [dbo].[KorisniciUloge] ADD CONSTRAINT [FK_KorisniciUloge_Uloge] FOREIGN KEY ([UlogaId]) REFERENCES [dbo].[Uloge] ([UlogaId])
GO
