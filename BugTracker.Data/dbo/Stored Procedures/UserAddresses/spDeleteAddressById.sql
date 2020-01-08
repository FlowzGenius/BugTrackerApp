CREATE PROCEDURE [dbo].[spDeleteAddressById]
	@Id UniqueIdentifier
AS
begin
	set nocount on;
	Update UserAddress
	set IsDeleted = 1
end
