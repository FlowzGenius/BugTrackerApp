using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackeData.Library.Internal.Constants.StoredProcedures
{
    public static class SpTeam
    {
        public static string SpCreateTeam { get; set; } = "dbo.spCreateTeam";
        public static string SpDeleteTeamById { get; set; } = "dbo.spDeleteTeamById";
        public static string SpGetAllTeams { get; set; } = "dbo.spGetAllTeams";
        public static string SpGetTeamById { get; set; } = "dbo.spGetTeamById";
        public static string SpUpdateTeam { get; set; } = "dbo.spUpdateTeam";
    }
}
