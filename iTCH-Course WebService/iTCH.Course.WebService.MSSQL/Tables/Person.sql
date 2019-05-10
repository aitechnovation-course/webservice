CREATE TABLE [dbo].[Person]
(
	[Id] INT NOT NULL, 
    [Name] NVARCHAR(200) NOT NULL, 
    [Email] NVARCHAR(500) NULL, 
    CONSTRAINT [PK_Person] PRIMARY KEY ([Id]) 
)
