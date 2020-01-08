using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackeData.Library.Internal.Constants.StoredProcedures
{
    public static class SpTicketStatus
    {
        public static string SpCreateTicketStatus { get; set; } = "dbo.spCreateTicketStatus";
        public static string SpDeleteTicketStatus { get; set; } = "dbo.spDeleteTicketStatus";
        public static string SpUpdateTicketStatus { get; set; } = "dbo.spUpdateTicketStatus";
        public static string SpGetCustomStatuses { get; set; } = "dbo.spUpdateTicketStatus";
    }
}
