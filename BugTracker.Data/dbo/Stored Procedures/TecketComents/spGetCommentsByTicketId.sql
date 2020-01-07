CREATE PROCEDURE [dbo].[spGetCommentsByTicketId]
	@TicketId UniqueIdentifier
AS
BEGIN
	set nocount on;

	Select [Id], [Comment], [AuthorID], [CreateDate] from TicketComment
	where [TicketID] = @TicketId  AND IsDeleted = 0 Order by [CreateDate];
END
