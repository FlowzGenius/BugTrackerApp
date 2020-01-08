using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackeData.Library.Internal.Constants.StoredProcedures
{
    public static class SpTicketType
    {
        public static string SpCreateTicketType { get; set; } = "dbo.spCreateTicketType";
        public static string SpDeleteTicketType { get; set; } = "dbo.spDeleteTicketType";
        public static string SpUpdateTicketType { get; set; } = "dbo.spUpdateTicketType";
        public static string SpGetCustomTypes { get; set; } = "dbo.spGetCustomTypes";
    }
}
