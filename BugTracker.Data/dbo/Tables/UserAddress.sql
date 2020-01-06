﻿CREATE TABLE [dbo].[UserAddress]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT newID(), 
    [UserID] UNIQUEIDENTIFIER NOT NULL, 
    [Address] NVARCHAR(350) NOT NULL, 
    CONSTRAINT [FK_UserAddress_ToUser] FOREIGN KEY ([UserID]) REFERENCES [UserInformation]([ID])
)