CREATE PROCEDURE [dbo].[spDeleteTicketById]
	@Id UniqueIdentifier
AS
Begin
    set nocount on;
   Update Ticket
   set IsDeleted = 1
   Where Id = @Id
end
