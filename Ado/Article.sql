CREATE TABLE [dbo].[Article]
(
	[Id] INT IDENTITY,
	[Name] varchar(50) NOT NULL, 
    [Price] FLOAT NOT NULL, 
    [Ean] BIGINT NOT NULL, 
    [Description] VARCHAR(255) NOT NULL, 
    Constraint [PK_ARTICLE] PRIMARY KEY ([Id])
	
	
)
