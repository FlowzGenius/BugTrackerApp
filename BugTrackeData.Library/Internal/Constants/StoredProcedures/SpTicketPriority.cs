using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackeData.Library.Internal.Constants.StoredProcedures
{
    public static class SpTicketPriority
    {
        public static string SpCreateTicketPriority { get; set; } = "dbo.spCreateTicketPriority";
        public static string SpDeleteTicketPriority { get; set; } = "dbo.spDeleteTicketPriority";
        public static string SpUpdateTicketPriority { get; set; } = "dbo.spUpdateTicketPriority";
        public static string SpGetCustomPriorities { get; set; } = "dbo.spGetCustomPriorities";
    }
}
