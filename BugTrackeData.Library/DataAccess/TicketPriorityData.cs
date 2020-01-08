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
    public class TicketPriorityData : ITicketPriorityData
    {
        private readonly ISqlDataAccess _dataAccess;

        public TicketPriorityData(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void CreateTicketPriority(TicketPriorityModel type)
        {
            try
            {
                _dataAccess.ManageData(SpTicketPriority.SpCreateTicketPriority, type, CnnStringConfig.BugTrackerCnnString);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void DeleteTicketPriority(Guid id)
        {
            try
            {
                var param = new { Id = id };

                _dataAccess.ManageData(SpTicketPriority.SpDeleteTicketPriority, param, CnnStringConfig.BugTrackerCnnString);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void UpdateTicketPriority(TicketPriorityModel type)
        {
            try
            {
                _dataAccess.ManageData(SpTicketPriority.SpUpdateTicketPriority, type, CnnStringConfig.BugTrackerCnnString);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TicketPriorityModel> GetCustomPriorites()
        {
            try
            {
                var output = _dataAccess.LoadData<TicketPriorityModel, dynamic>(SpTicketPriority.SpGetCustomPriorities, new { },
                    CnnStringConfig.BugTrackerCnnString);

                return output;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
