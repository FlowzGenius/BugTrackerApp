using BugTrackeData.Library.Models;
using System;
using System.Collections.Generic;

namespace BugTrackeData.Library.DataAccess.Contracts
{
    public interface ITicketCommentData
    {
        void CreateComment(TicketCommentModel comment);
        void DeleteComment(Guid id);
        List<TicketCommentModel> GetTicketComments(Guid ticketID);
    }
}