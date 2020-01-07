using BugTrackeData.Library.DataAccess.Contracts;
using BugTrackeData.Library.Internal.DataAccess.Contracts;
using BugTrackeData.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackeData.Library.DataAccess
{
    public class ProjectData : IProjectData
    {
        private readonly ISqlDataAccess _dataAccess;

        public ProjectData(ISqlDataAccess dataAccess)
        {
            this._dataAccess = dataAccess;
        }

        public void CreateProject(ProjectModel project)
        {
            try
            {
                _dataAccess.ManageData("dbo.spCreateProject", project, "BugTrackerData");
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public List<ProjectModel> GetAllProjects()
        {
            try
            {
                var output = _dataAccess.LoadData<ProjectModel, dynamic>("dbo.spGetAllProjects", new { }, "BugTrackerData");

                return output;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteProject(Guid id)
        {
            try
            {
                var param = new { Id = id };

                _dataAccess.ManageData<dynamic>("dbo.spDeleteProjectById", param, "BugTrackerData");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public ProjectData GetProject(Guid id)
        {
            try
            {
                var param = new { Id = id };

                var output = _dataAccess.GetObject<ProjectData, dynamic>("dbo.spGetProjectById", param, "BugTrackerData");

                return output;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void UpdateProject(ProjectModel project)
        {

            try
            {
                _dataAccess.ManageData("dbo.spUpdateProject", project, "BugTrackerData");
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
