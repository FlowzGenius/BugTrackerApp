CREATE PROCEDURE [dbo].[spDeleteTeamById]
	@Id UniqueIdentifier
AS
Begin
    set nocount on;
   Update Team
   set IsDeleted = 1
   Where Id = @Id
end
