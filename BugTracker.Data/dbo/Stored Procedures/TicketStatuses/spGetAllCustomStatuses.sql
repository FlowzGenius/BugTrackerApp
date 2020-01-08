CREATE PROCEDURE [dbo].[spGetAllCustomStatuses]
AS
begin
	set nocount on;

	Select  [Id], [Status] from TicketStatus
	Where IsCustom = 1;
end
