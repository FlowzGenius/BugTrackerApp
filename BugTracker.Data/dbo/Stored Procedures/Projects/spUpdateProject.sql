CREATE PROCEDURE [dbo].[spUpdateProject]
	@Id UniqueIdentifier,
	@Description Text,
	@TeamID UniqueIdentifier
AS
begin
	set nocount on

	Update Project
	set [Description] = @Description, [TeamID] = @TeamID
	Where Id = @Id
end
