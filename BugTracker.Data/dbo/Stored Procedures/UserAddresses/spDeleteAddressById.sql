CREATE PROCEDURE [dbo].[spDeleteAddressById]
	@Id UniqueIdentifier
AS
begin
	Update UserAddress
	set IsDeleted = 1
end
