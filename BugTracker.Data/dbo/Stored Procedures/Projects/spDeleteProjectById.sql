CREATE PROCEDURE [dbo].[spDeleteProjectById]
	@Id UniqueIdentifier
AS
Begin
   Update Project
   set IsDeleted = 1
   Where Id = @Id
end
