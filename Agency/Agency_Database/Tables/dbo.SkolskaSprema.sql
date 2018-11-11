CREATE TABLE [dbo].[SkolskaSprema]
(
[SkolskaSpremaId] [int] NOT NULL IDENTITY(1, 1),
[Naziv] [nvarchar] (50) COLLATE Latin1_General_CI_AI NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[SkolskaSprema] ADD CONSTRAINT [CS_NazivSkolskaSprema] UNIQUE NONCLUSTERED  ([Naziv]) ON [PRIMARY]

GO
ALTER TABLE [dbo].[SkolskaSprema] ADD CONSTRAINT [PK_SkolskaSprema] PRIMARY KEY CLUSTERED  ([SkolskaSpremaId]) ON [PRIMARY]
GO
