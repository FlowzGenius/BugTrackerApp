using BugTrackeData.Library.Models;
using System;
using System.Collections.Generic;

namespace BugTrackeData.Library.DataAccess.Contracts
{
    public interface ITicketData
    {
        void CreateTicket(TicketModel project);
        void DeleteTicket(Guid id);
        List<TicketModel> GetAllTickets();
        TicketData GetTicket(Guid id);
        void UpdateTicket(TicketModel project);
    }
}