using BugTrackeData.Library.Internal.DataAccess.Contracts;
using BugTrackeData.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackeData.Library.DataAccess
{
    public class ProjectData
    {
        private readonly ISqlDataAccess _dataAccess;

        public ProjectData(ISqlDataAccess dataAccess)
        {
            this._dataAccess = dataAccess;
        }

        public void CreateProject(ProjectModel project)
        {
            
        }
    }
}
