CREATE PROCEDURE [dbo].[spGetTeamById]
	@Id UniqueIdentifier
AS
begin
 set nocount on;

 Select [Name], [CreatorID], [CreateDate] from Team
 where Id = @Id AND IsDeleted = 0
end
