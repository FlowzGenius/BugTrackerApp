CREATE TABLE [dbo].[Ticket]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT newid(), 
    [Description] NVARCHAR(250) NOT NULL, 
    [TypeID] UNIQUEIDENTIFIER NOT NULL, 
    [ProjectID] UNIQUEIDENTIFIER NOT NULL, 
    [DeveloperID] UNIQUEIDENTIFIER NOT NULL, 
    [StatusID] UNIQUEIDENTIFIER NOT NULL, 
    [PriorityID] UNIQUEIDENTIFIER NOT NULL, 
    [CreateDate] DATETIME2 NOT NULL DEFAULT getdate(), 
    CONSTRAINT [FK_Ticket_ToType] FOREIGN KEY ([TypeID]) REFERENCES [TicketType]([ID]), 
    CONSTRAINT [FK_Ticket_ToProject] FOREIGN KEY ([ProjectID]) REFERENCES [Project]([ID]), 
    CONSTRAINT [FK_Ticket_ToUser] FOREIGN KEY ([DeveloperID]) REFERENCES [UserInformation]([ID]), 
    CONSTRAINT [FK_Ticket_ToStatus] FOREIGN KEY ([StatusID]) REFERENCES [TicketStatus]([ID]), 
    CONSTRAINT [FK_Ticket_ToToPriority] FOREIGN KEY ([PriorityID]) REFERENCES [TicketPriority]([ID]) 
)
