CREATE PROCEDURE [dbo].[spDeleteTicketStatus]
	@Id UniqueIdentifier
AS
begin
	set nocount on

	Delete from TicketStatus 
	where [Id] = @Id
end
