using BugTrackeData.Library.Models;
using System;
using System.Collections.Generic;

namespace BugTrackeData.Library.DataAccess.Contracts
{
    public interface IProjectData
    {
        void CreateProject(ProjectModel project);
        void DeleteProject(Guid id);
        List<ProjectModel> GetAllProjects();
        ProjectData GetProject(Guid id);
        void UpdateProject(ProjectModel project);
    }
}