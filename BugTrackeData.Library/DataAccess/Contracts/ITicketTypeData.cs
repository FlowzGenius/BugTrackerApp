using BugTrackeData.Library.Models;
using System;
using System.Collections.Generic;

namespace BugTrackeData.Library.DataAccess.Contracts
{
    public interface ITicketTypeData
    {
        void CreateTicketType(TicketTypeModel type);
        void DeleteTicketType(Guid id);
        List<TicketTypeModel> GetCustomTypes();
        void UpdateTicketType(TicketTypeModel type);
    }
}