using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackeData.Library.Internal.Constants.StoredProcedures
{
    public static class SpTicketComment
    {
        public static string SpCreateComment { get; set; } = "dbp.spCreateComment";
        public static string SpDeleteComment { get; set; } = "dbp.spDeleteComment";
        public static string SpGetCommentsByTicketId { get; set; } = "dbp.spGetCommentsByTicketId";
    }
}
