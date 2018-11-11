CREATE TABLE [dbo].[Struka]
(
[StrukaId] [int] NOT NULL IDENTITY(1, 1),
[Naziv] [nvarchar] (50) COLLATE Latin1_General_CI_AI NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Struka] ADD CONSTRAINT [CS_NazivStruka] UNIQUE NONCLUSTERED  ([Naziv]) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Struka] ADD CONSTRAINT [PK_Struka] PRIMARY KEY CLUSTERED  ([StrukaId]) ON [PRIMARY]
GO
