﻿CREATE TABLE [dbo].[Orders]
(
	[OrderID] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
	[OrderQty] INT NOT NULL, 
	[ItemID] INT NOT NULL, 
	[ItemName] VARCHAR(40) NOT NULL, 
	[PerItemPrice]MONEY NOT NULL, 
	[TotalPrice]MONEY NOT NULL
	
)
