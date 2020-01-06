CREATE TABLE [dbo].[TicketComment]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Comment] NVARCHAR(500) NOT NULL, 
    [TicketID] UNIQUEIDENTIFIER NOT NULL, 
    [AuthorID] UNIQUEIDENTIFIER NOT NULL, 
    [CreateDate] DATETIME2 NOT NULL DEFAULT getdate(), 
    [IsDeleted] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_TicketComment_ToTicket] FOREIGN KEY ([TicketID]) REFERENCES [Ticket]([Id]), 
    CONSTRAINT [FK_TicketComment_ToUser] FOREIGN KEY ([AuthorID]) REFERENCES [UserInformation]([Id])
)
