CREATE TABLE [dbo].[Mjesta]
(
[MjestoId] [int] NOT NULL IDENTITY(1, 1),
[DrzavaId] [int] NULL,
[Naziv] [nchar] (50) COLLATE Latin1_General_CI_AI NOT NULL,
[PostanskiBroj] [nchar] (15) COLLATE Latin1_General_CI_AI NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Mjesta] ADD CONSTRAINT [CS_NazivMjesta] UNIQUE NONCLUSTERED  ([Naziv]) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Mjesta] ADD CONSTRAINT [PK_Mjesta] PRIMARY KEY CLUSTERED  ([MjestoId]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Mjesta] ADD CONSTRAINT [FK_Mjesta_Drzave] FOREIGN KEY ([DrzavaId]) REFERENCES [dbo].[Drzave] ([DrzavaId])
GO
