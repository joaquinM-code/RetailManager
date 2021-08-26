CREATE TABLE [dbo].[Item]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ItemName] NVARCHAR(100) NOT NULL, 
    [Description] NVARCHAR(MAX) NULL,
    [RetailPrice] MONEY NOT NULL,   
    [CreateDate] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [LastModified] DATETIME2 NOT NULL DEFAULT getutcdate()
)
