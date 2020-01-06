CREATE PROCEDURE [dbo].[spGetAllTeams]

AS
begin 
 set nocount on

 Select [Name] , [CreatorID], [CreateDate] from Team
 Where IsDeleted = 0;
end
