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
                _dataAccess.ManageData(SpTeam.SpCreateTeam, project, CnnStringConfig.BugTrackerCnnString);
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
                var output = _dataAccess.LoadData<TeamModel, dynamic>(SpTeam.SpGetAllTeams, new { }, CnnStringConfig.BugTrackerCnnString);

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

                _dataAccess.ManageData<dynamic>(SpTeam.SpDeleteTeamById, param, CnnStringConfig.BugTrackerCnnString);
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

                var output = _dataAccess.GetObject<TeamData, dynamic>(SpTeam.SpGetTeamById, param, CnnStringConfig.BugTrackerCnnString);

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
                _dataAccess.ManageData(SpTeam.SpUpdateTeam, project, CnnStringConfig.BugTrackerCnnString);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}

