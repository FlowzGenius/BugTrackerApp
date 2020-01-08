CREATE PROCEDURE [dbo].[spCreateTicketPriority]
		@Priority Text
AS
begin
	set nocount on

	Insert Into TicketPriority([Priority], [IsCustom])
	Values(@Priority, 1);
end
