CREATE TABLE [dbo].[Uloge]
(
[UlogaId] [int] NOT NULL IDENTITY(1, 1),
[Naziv] [nvarchar] (50) COLLATE Latin1_General_CI_AI NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Uloge] ADD CONSTRAINT [CS_NazivUloge] UNIQUE NONCLUSTERED  ([Naziv]) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Uloge] ADD CONSTRAINT [PK_Uloge] PRIMARY KEY CLUSTERED  ([UlogaId]) ON [PRIMARY]
GO
