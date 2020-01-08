CREATE PROCEDURE [dbo].[spDeleteProjectById]
	@Id UniqueIdentifier
AS
Begin
    set nocount on;
   Update Project
   set IsDeleted = 1
   Where Id = @Id
end
