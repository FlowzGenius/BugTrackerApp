using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackeData.Library.Models
{
    public class TeamModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CreatorID { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
