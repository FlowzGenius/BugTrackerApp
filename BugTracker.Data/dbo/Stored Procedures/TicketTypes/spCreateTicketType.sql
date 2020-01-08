CREATE PROCEDURE [dbo].[spCreateTicketType]
	@Type Text
AS
begin
	set nocount on

	Insert Into TicketType([Type], [IsCustom])
	Values(@Type, 1);
end
