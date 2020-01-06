CREATE PROCEDURE [dbo].[spGetAllProjects]

AS
begin 
 set nocount on

 Select [Description] , [CreatorID], [TeamID], [CreateDate] from Project
 where IsDeleted = 0;
end
