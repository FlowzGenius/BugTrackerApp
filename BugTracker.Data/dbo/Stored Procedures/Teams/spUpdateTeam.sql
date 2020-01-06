CREATE PROCEDURE [dbo].[spUpdateTeam]
	@Id UniqueIdentifier,
	@Name Text
AS
begin
	set nocount on

	Update Team
	set [Name] = @Name
	Where Id = @Id
end
