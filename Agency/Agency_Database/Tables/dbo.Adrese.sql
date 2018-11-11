CREATE TABLE [dbo].[Adrese]
(
[AdresaId] [int] NOT NULL IDENTITY(1, 1),
[UlicaIBroj] [nvarchar] (50) COLLATE Latin1_General_CI_AI NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Adrese] ADD CONSTRAINT [PK_Adrese] PRIMARY KEY CLUSTERED  ([AdresaId]) ON [PRIMARY]
GO
