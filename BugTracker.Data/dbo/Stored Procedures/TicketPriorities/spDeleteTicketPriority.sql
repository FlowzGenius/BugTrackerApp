CREATE PROCEDURE [dbo].[DeleteTicketPriority]
	@Id UniqueIdentifier
AS
begin
	set nocount on

	Delete from TicketPriority 
	where [Id] = @Id
end
