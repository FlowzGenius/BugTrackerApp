using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackeData.Library.Internal.Constants.StoredProcedures
{
    public static class SpProject
    {
        public static string SpCreateProject { get; set; } = "dbo.spCreateProject";
        public static string SpDeleteProjectById { get; set; } = "dbo.spDeleteProjectById";
        public static string SpGetAllProjects { get; set; } = "dbo.spGetAllProjects";
        public static string SpGetProjectById { get; set; } = "dbo.spGetProjectById";
        public static string SpUpdateProject { get; set; } = "dbo.spUpdateProject";
    }
}
