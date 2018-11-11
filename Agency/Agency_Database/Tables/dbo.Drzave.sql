CREATE TABLE [dbo].[Drzave]
(
[DrzavaId] [int] NOT NULL IDENTITY(1, 1),
[Naziv] [nchar] (50) COLLATE Latin1_General_CI_AI NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Drzave] ADD CONSTRAINT [CS_NazivDrzave] UNIQUE NONCLUSTERED  ([Naziv]) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Drzave] ADD CONSTRAINT [PK_Drzave] PRIMARY KEY CLUSTERED  ([DrzavaId]) ON [PRIMARY]
GO
