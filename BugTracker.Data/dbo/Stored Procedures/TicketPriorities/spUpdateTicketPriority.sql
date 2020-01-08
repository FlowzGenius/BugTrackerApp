CREATE PROCEDURE [dbo].[UpdateTicketPriority]
	@Priority Text
AS
begin
	set nocount on;

	Update TicketPriority
	set [Priority] = @Priority;
end
