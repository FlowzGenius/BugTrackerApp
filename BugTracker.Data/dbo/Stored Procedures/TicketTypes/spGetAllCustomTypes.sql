CREATE PROCEDURE [dbo].[spGetAllCustomTypes]
AS
begin
	set nocount on;

	Select [Id], [Type] from TicketType
	where IsCustom = 1;
end
