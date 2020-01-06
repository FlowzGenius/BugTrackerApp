CREATE PROCEDURE [dbo].[spGetUserById]
	@Id UniqueIdentifier
AS
begin
 set nocount on;

 Select [Name], [Surname], [Email], [TeamID], [IsDeleted] from UserInformation
 where Id = @Id AND IsDeleted = 0
end
