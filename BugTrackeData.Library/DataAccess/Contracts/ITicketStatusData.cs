using BugTrackeData.Library.Models;
using System;
using System.Collections.Generic;

namespace BugTrackeData.Library.DataAccess.Contracts
{
    public interface ITicketStatusData
    {
        void CreateTicketStatus(TicketStatusModel type);
        void DeleteTicketStatus(Guid id);
        List<TicketStatusModel> GetCustomStatuses();
        void UpdateTicketStatus(TicketStatusModel type);
    }
}