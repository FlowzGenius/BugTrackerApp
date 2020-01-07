using BugTrackeData.Library.DataAccess.Contracts;
using BugTrackeData.Library.Internal.DataAccess.Contracts;
using BugTrackeData.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackeData.Library.DataAccess
{
    public class TicketCommentData : ITicketCommentData
    {
        private readonly ISqlDataAccess _dataAccess;

        public TicketCommentData(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void DeleteComment(Guid id)
        {
            try
            {
                var param = new { Id = id };

                _dataAccess.ManageData("dbo.spDeleteComment", param, "BugTrackerData");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void CreateComment(TicketCommentModel comment)
        {
            try
            {
                _dataAccess.ManageData("dbo.spCreateComment", comment, "BugTrackerData");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TicketCommentModel> GetTicketComments(Guid ticketID)
        {
            try
            {
                var param = new { TicketId = ticketID };

                var output = _dataAccess.LoadData<TicketCommentModel, dynamic>("dbo.spGetTicketCommentsByTicketId", param, "BugTrackerData");

                return output;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
