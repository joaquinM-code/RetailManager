CREATE TABLE [dbo].[SaleDetail]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [SaleId] INT NOT NULL, 
    [Quantity] INT NOT NULL,
    [ItemId] INT NOT NULL, 
    [PurchasePrice] MONEY NOT NULL, 
    [Tax] MONEY NOT NULL DEFAULT 0, 
)
