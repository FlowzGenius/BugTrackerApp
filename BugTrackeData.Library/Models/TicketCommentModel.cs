using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackeData.Library.Models
{
    public class TicketCommentModel
    {
        public Guid Id { get; set; }
        public string Comment { get; set; }
        public Guid TicketID { get; set; }
        public Guid AuthorID { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
