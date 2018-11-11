CREATE TABLE [dbo].[TipAktivnosti]
(
[TipAktivnostiId] [int] NOT NULL IDENTITY(1, 1),
[Naziv] [nvarchar] (50) COLLATE Latin1_General_CI_AI NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TipAktivnosti] ADD CONSTRAINT [CS_NazivTipAktivnosti] UNIQUE NONCLUSTERED  ([Naziv]) ON [PRIMARY]

GO
ALTER TABLE [dbo].[TipAktivnosti] ADD CONSTRAINT [PK_TipAktivnosti] PRIMARY KEY CLUSTERED  ([TipAktivnostiId]) ON [PRIMARY]
GO
