CREATE PROCEDURE [dbo].[spUpdateTicket]
	@Id UniqueIdentifier,
	@Description Text,
	@TypeID UniqueIdentifier,
	@ProjectID UniqueIdentifier,
	@DeveloperID UniqueIdentifier,
	@StatusID UniqueIdentifier,
	@PriorityID UniqueIdentifier
AS
begin
	set nocount on

	Update Ticket
	set [Description] = @Description, [TypeID] = @TypeID, [ProjectID] = @ProjectID, [DeveloperID] = @DeveloperID, [StatusID] = @StatusID,
	[PriorityID] = @PriorityID
	Where Id = @Id
end
