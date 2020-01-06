CREATE PROCEDURE [dbo].[spCreateTicket]
	@Description Text,
	@TypeID UniqueIdentifier,
	@ProjectID UniqueIdentifier,
    @DeveloperID UniqueIdentifier,
    @PriorityID UniqueIdentifier,
    @StatusID UniqueIdentifier

As
begin 
  set nocount on;
  
  Insert Into Ticket([Description], [TypeID], [ProjectID], [DeveloperID], [PriorityID], [StatusID])
  Values (@Description, @TypeID, @ProjectID, @DeveloperID, @PriorityID, @StatusID)
end