CREATE PROCEDURE [dbo].[spGetCustomPriorities]
AS
begin
	set nocount on;

	Select [Id], [Priority] from TicketPriority
	where IsCustom = 1;
end
