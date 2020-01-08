CREATE PROCEDURE [dbo].[spCreateTicketStatus]
	@Status Text
AS
begin
	set nocount on

	Insert Into TicketStatus([Status], [IsCustom])
	Values(@Status, 1);
end
