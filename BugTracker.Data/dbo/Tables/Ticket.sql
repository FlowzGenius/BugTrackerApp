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
    [IsDeleted] BIT NOT NULL DEFAULT 0, 

    CONSTRAINT [FK_Ticket_ToType] FOREIGN KEY ([TypeID]) REFERENCES [TicketType]([Id]), 
    CONSTRAINT [FK_Ticket_ToProject] FOREIGN KEY ([ProjectID]) REFERENCES [Project]([Id]), 
    CONSTRAINT [FK_Ticket_ToUser] FOREIGN KEY ([DeveloperID]) REFERENCES [UserInformation]([Id]), 
    CONSTRAINT [FK_Ticket_ToStatus] FOREIGN KEY ([StatusID]) REFERENCES [TicketStatus]([Id]), 
    CONSTRAINT [FK_Ticket_ToToPriority] FOREIGN KEY ([PriorityID]) REFERENCES [TicketPriority]([Id]) 
)
