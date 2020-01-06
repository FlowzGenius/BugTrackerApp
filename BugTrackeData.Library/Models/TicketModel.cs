using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackeData.Library.Models
{
    public class TicketModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public Guid TypeID { get; set; }
        public Guid ProjectID { get; set; }
        public Guid DeveloperID { get; set; }
        public Guid StatusID { get; set; }
        public Guid PriorityID { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
