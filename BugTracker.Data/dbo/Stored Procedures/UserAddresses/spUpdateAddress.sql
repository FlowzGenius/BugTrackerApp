CREATE PROCEDURE [dbo].[spUpdateAddress]
	@Id UniqueIdentifier,
	@Address Text
AS
begin
	set nocount on;

	Update UserAddress
	set [Address] = @Address
end
