CREATE PROCEDURE [dbo].[spCreateUser]
	@Name Text,
    @Surname Text,
    @Email Text,
	@TeamID UniqueIdentifier

As
begin 
  set nocount on;
  
  Insert Into UserInformation([Name], [Surname], [Email], [TeamID])
  Values (@Name, @Surname, @Email, @TeamID)
end