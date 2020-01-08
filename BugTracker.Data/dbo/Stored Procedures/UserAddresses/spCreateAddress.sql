CREATE PROCEDURE [dbo].[spCreateAddress]
	@UserId UniqueIdentifier,
	@Address Text
AS
begin
	set nocount on;
	Insert into UserAddress([UserID], [Address])
	Values (@UserId, @Address);
end