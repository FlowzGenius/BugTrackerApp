CREATE PROCEDURE [dbo].[spCreateProject]
	@Description Text,
	@CreatorID UniqueIdentifier,
	@TeamID UniqueIdentifier
As
begin 
  set nocount on;
  
  Insert Into Project([Description], [CreatorID], [TeamID])
  Values (@Description, @CreatorID, @TeamID)
end
