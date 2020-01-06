CREATE PROCEDURE [dbo].[spGetAddressesByUserId]
	@UserId UniqueIdentifier
AS
begin
	set nocount on;

	Select [UserID], [Address] from UserAddress
	Where [UserID] = @UserId;
end
