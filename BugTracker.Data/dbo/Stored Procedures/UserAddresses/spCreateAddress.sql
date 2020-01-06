CREATE PROCEDURE [dbo].[spCreateAddress]
	@UserId UniqueIdentifier,
	@Address Text
AS
begin
	Insert into UserAddress([UserID], [Address])
	Values (@UserId, @Address);
end