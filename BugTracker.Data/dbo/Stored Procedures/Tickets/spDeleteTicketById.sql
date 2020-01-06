CREATE PROCEDURE [dbo].[spDeleteTicketById]
	@Id UniqueIdentifier
AS
Begin
   Update Ticket
   set IsDeleted = 1
   Where Id = @Id
end
