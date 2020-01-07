CREATE PROCEDURE [dbo].[spUpdateUser]
	@Id UniqueIdentifier,
	@Name Text,
	@Surname Text,
	@Email Text,
	@TeamID UniqueIdentifier
AS
begin
	set nocount on

	Update UserInformation
	set [Name] = @Name, [Surname] = @Surname, [Email] = @Email, [TeamID] = @TeamID
	Where Id = @Id
end
