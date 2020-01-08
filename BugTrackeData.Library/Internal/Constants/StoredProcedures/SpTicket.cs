using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackeData.Library.Internal.Constants.StoredProcedures
{
    public static class SpTicket
    {
        public static string SpCreateTicket { get; set; } = "dbo.spCreateTicket";
        public static string SpDeleteTicketById { get; set; } = "dbo.spDeleteTicketById";
        public static string SpGetAllTickets { get; set; } = "dbo.spGetAllTickets";
        public static string SpGetTicketById { get; set; } = "dbo.spGetTicketById";
        public static string SpUpdateTicket { get; set; } = "dbo.spUpdateTicket";
    }
}
