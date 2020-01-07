using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackeData.Library.Models
{
    public class AddressModel
    {
        public Guid Id { get; set; }
        public Guid UserID { get; set; }
        public string Address { get; set; }
    }
}
