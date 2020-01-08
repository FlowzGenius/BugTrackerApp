using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackeData.Library.Internal.Constants.StoredProcedures
{
    public static class SpUserInformation
    {
        public static string SpCreateUser { get; set; } = "dbo.spCreateUser";
        public static string SpDeleteUserById { get; set; } = "dbo.spDeleteUserById";
        public static string SpGetAllUsers { get; set; } = "dbo.spGetAllUsers";
        public static string SpGetUserById { get; set; } = "dbo.spGetUserById";
        public static string SpUpdateUser { get; set; } = "dbo.spUpdateUser";
    }
}
