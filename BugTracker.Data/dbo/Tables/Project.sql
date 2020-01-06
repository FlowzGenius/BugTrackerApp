﻿CREATE TABLE [dbo].[Project]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [Description] NVARCHAR(150) NOT NULL, 
    [CreatorID] UNIQUEIDENTIFIER NOT NULL, 
    [TeamID] UNIQUEIDENTIFIER NOT NULL, 
    [CreateDate] DATETIME2 NOT NULL DEFAULT getdate(), 
    CONSTRAINT [FK_Project_ToUser] FOREIGN KEY (CreatorID) REFERENCES [UserInformation]([Id]), 
    CONSTRAINT [FK_Project_ToTeam] FOREIGN KEY ([TeamID]) REFERENCES [Team]([Id]) 
)
