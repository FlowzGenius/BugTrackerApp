CREATE PROCEDURE [dbo].[spCreateTeam]
	@Name Text,
	@CreatorID UniqueIdentifier,
	@TeamID UniqueIdentifier
As
begin 
  set nocount on;
  
  Insert Into Team([Name], [CreatorID])
  Values (@Name, @CreatorID)
end
