CREATE PROCEDURE [dbo].[UpdateTicketType]
	@Type Text
AS
begin
	set nocount on;

	Update TicketType
	set [Type] = @Type;
end
