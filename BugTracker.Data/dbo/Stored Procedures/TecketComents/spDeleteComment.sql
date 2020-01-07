CREATE PROCEDURE [dbo].[spDeleteComment]
	@Id UniqueIdentifier
AS
begin
	set nocount on;

	Update TicketComment
	Set IsDeleted = 1;
end
