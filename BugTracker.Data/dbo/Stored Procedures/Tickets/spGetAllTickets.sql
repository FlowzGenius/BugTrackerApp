CREATE PROCEDURE [dbo].[spGetAllTickets]

AS
begin 
 set nocount on

 Select [Description] , [TypeID], [PriorityID], [DeveloperID], [StatusID], [PriorityID] from Ticket
 Where IsDeleted = 0;
end
