using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackeData.Library.Models
{
    public class ProjectModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public Guid CreatorID { get; set; }
        public Guid TeamID { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
