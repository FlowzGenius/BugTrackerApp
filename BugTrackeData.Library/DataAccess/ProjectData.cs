using BugTrackeData.Library.DataAccess.Contracts;
using BugTrackeData.Library.Internal.Constants.ConnectionStringName;
using BugTrackeData.Library.Internal.Constants.StoredProcedures;
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
                _dataAccess.ManageData(SpProject.SpCreateProject, project, CnnStringConfig.BugTrackerCnnString);
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
                var output = _dataAccess.LoadData<ProjectModel, dynamic>(SpProject.SpGetAllProjects, new { }, CnnStringConfig.BugTrackerCnnString);

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

                _dataAccess.ManageData<dynamic>(SpProject.SpDeleteProjectById, param, CnnStringConfig.BugTrackerCnnString);
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

                var output = _dataAccess.GetObject<ProjectData, dynamic>(SpProject.SpGetProjectById, param, CnnStringConfig.BugTrackerCnnString);

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
                _dataAccess.ManageData(SpProject.SpUpdateProject, project, CnnStringConfig.BugTrackerCnnString);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
