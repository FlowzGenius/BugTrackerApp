CREATE PROCEDURE [dbo].[spGetProjectById]
	@Id UniqueIdentifier
AS
begin
 set nocount on;

 Select [Description], [CreatorID], [TeamID], [CreateDate] from Project
 where Id = @Id AND IsDeleted = 0
end
