CREATE PROCEDURE [dbo].[spDeleteTeamById]
	@Id UniqueIdentifier
AS
Begin
   Update Team
   set IsDeleted = 1
   Where Id = @Id
end
