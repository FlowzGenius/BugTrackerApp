CREATE PROCEDURE [dbo].[spUpdateTicketStatus]
	@Status Text
AS
begin
	set nocount on;

	Update TicketStatus
	set [Status] = @Status;
end
