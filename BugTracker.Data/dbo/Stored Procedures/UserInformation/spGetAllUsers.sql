CREATE PROCEDURE [dbo].[spGetAllUsers]

AS
begin 
 set nocount on

 Select [Name] , [Surname], [Email], [TeamID], [IsDeleted] from UserInformation
end
