using BugTrackeData.Library.DataAccess.Contracts;
using BugTrackeData.Library.Internal.DataAccess.Contracts;
using BugTrackeData.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackeData.Library.DataAccess
{
    public class TeamData : ITeamData
    {
        private readonly ISqlDataAccess _dataAccess;

        public TeamData(ISqlDataAccess dataAccess)
        {
            this._dataAccess = dataAccess;
        }

        public void CreateTeam(TeamModel project)
        {
            try
            {
                _dataAccess.ManageData("dbo.spCreateTeam", project, "BugTrackerData");
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public List<TeamModel> GetAllTeams()
        {
            try
            {
                var output = _dataAccess.LoadData<TeamModel, dynamic>("dbo.spGetAllTeams", new { }, "BugTrackerData");

                return output;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteTeam(Guid id)
        {
            try
            {
                var param = new { Id = id };

                _dataAccess.ManageData<dynamic>("dbo.spDeleteTeamById", param, "BugTrackerData");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public TeamData GetTeam(Guid id)
        {
            try
            {
                var param = new { Id = id };

                var output = _dataAccess.GetObject<TeamData, dynamic>("dbo.spGetTeamById", param, "BugTrackerData");

                return output;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void UpdateTeam(TeamModel project)
        {

            try
            {
                _dataAccess.ManageData("dbo.spUpdateTeam", project, "BugTrackerData");
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}

