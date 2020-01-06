CREATE PROCEDURE [dbo].[spGetTicketById]
	@Id UniqueIdentifier
AS
begin
 set nocount on;

 Select [Description], [TypeID], [ProjectID], [DeveloperID], [StatusID], [PriorityID] from Ticket
 where Id = @Id AND IsDeleted = 0
end
