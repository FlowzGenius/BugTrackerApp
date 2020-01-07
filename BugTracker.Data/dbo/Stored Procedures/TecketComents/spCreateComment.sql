CREATE PROCEDURE [dbo].[spCreateComment]
	@Comment Text,
	@TicketId UniqueIdentifier,
	@AuthorId UniqueIdentifier,
	@CreateDate DateTime2
AS
begin
	Insert Into TicketComment([Comment], [TicketID], [AuthorID], [CreateDate])
	Values (@Comment, @TicketId, @AuthorId, @CreateDate);
end
