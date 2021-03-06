﻿CREATE TABLE [dbo].[Team]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT newid(), 
    [Name] NVARCHAR(50) NOT NULL, 
    [CreatorID] UNIQUEIDENTIFIER NOT NULL,
    [CreateDate] DATETIME2 NOT NULL DEFAULT getdate(), 
    [IsDeleted] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_Team_ToUser] FOREIGN KEY ([CreatorID]) REFERENCES [UserInformation]([Id]) 
)
