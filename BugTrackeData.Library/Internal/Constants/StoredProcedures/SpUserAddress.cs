using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackeData.Library.Internal.Constants.StoredProcedures
{
    public static class SpUserAddress
    {
        public static string SpCreateAddress{ get; set; } = "dbo.spCreateAddress";
        public static string SpDeleteAddressById { get; set; } = "dbo.spDeleteAddressById";
        public static string SpGetAddressByUserId { get; set; } = "dbo.spGetAddressByUserId";
        public static string SpUpdateAddress { get; set; } = "dbo.spUpdateAddress";
    }
}
