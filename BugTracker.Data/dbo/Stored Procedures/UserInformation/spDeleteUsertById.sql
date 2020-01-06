CREATE PROCEDURE [dbo].[spDeleteUserById]
	@Id UniqueIdentifier
AS
Begin
   Update UserInformation
   set IsDeleted = 1
   Where Id = @Id
end
