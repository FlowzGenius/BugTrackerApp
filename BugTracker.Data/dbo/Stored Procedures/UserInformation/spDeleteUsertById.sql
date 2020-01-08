CREATE PROCEDURE [dbo].[spDeleteUserById]
	@Id UniqueIdentifier
AS
Begin
    set nocount on;
   Update UserInformation
   set IsDeleted = 1
   Where Id = @Id
end
