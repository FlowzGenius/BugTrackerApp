using BugTrackeData.Library.Models;
using System;
using System.Collections.Generic;

namespace BugTrackeData.Library.DataAccess.Contracts
{
    public interface ITeamData
    {
        void CreateTeam(TeamModel project);
        void DeleteTeam(Guid id);
        List<TeamModel> GetAllTeams();
        TeamData GetTeam(Guid id);
        void UpdateTeam(TeamModel project);
    }
}