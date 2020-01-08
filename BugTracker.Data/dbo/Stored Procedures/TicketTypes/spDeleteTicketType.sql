CREATE PROCEDURE [dbo].[DeleteTicketType]
	@Id UniqueIdentifier
AS
begin
	set nocount on

	Delete from TicketType 
	where [Id] = @Id
end
