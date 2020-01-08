using BugTrackeData.Library.Models;
using System;
using System.Collections.Generic;

namespace BugTrackeData.Library.DataAccess.Contracts
{
    public interface ITicketPriorityData
    {
        void CreateTicketPriority(TicketPriorityModel type);
        void DeleteTicketPriority(Guid id);
        List<TicketPriorityModel> GetCustomPriorites();
        void UpdateTicketPriority(TicketPriorityModel type);
    }
}