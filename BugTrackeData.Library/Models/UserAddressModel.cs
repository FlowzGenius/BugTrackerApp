using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackeData.Library.Models
{
    public class UserAddressModel
    {
        public Guid Id { get; set; }
        public Guid UserID { get; set; }
        public string Address { get; set; }
    }
}
