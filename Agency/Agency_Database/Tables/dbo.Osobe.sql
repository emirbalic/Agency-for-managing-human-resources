CREATE TABLE [dbo].[Osobe]
(
[OsobaId] [int] NOT NULL IDENTITY(1, 1),
[Ime] [nvarchar] (50) COLLATE Latin1_General_CI_AI NOT NULL,
[Prezime] [nvarchar] (50) COLLATE Latin1_General_CI_AI NOT NULL,
[JMBG] [nvarchar] (50) COLLATE Latin1_General_CI_AI NULL,
[AdresaId] [int] NOT NULL,
[MjestoId] [int] NOT NULL,
[Email] [nvarchar] (50) COLLATE Latin1_General_CI_AI NULL,
[Telefon] [nchar] (20) COLLATE Latin1_General_CI_AI NULL,
[Slika] [varbinary] (max) NULL,
[SlikaThumb] [varbinary] (max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Osobe] ADD CONSTRAINT [CS_Email] UNIQUE NONCLUSTERED  ([Email]) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Osobe] ADD CONSTRAINT [PK_Osobe] PRIMARY KEY CLUSTERED  ([OsobaId]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Osobe] ADD CONSTRAINT [FK_Osobe_Adrese] FOREIGN KEY ([AdresaId]) REFERENCES [dbo].[Adrese] ([AdresaId])
GO
ALTER TABLE [dbo].[Osobe] ADD CONSTRAINT [FK_Osobe_Mjesta] FOREIGN KEY ([MjestoId]) REFERENCES [dbo].[Mjesta] ([MjestoId])
GO
