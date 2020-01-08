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
    public class TicketStatusData : ITicketStatusData
    {
        private readonly ISqlDataAccess _dataAccess;

        public TicketStatusData(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void CreateTicketStatus(TicketStatusModel type)
        {
            try
            {
                _dataAccess.ManageData(SpTicketStatus.SpCreateTicketStatus, type, CnnStringConfig.BugTrackerCnnString);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void DeleteTicketStatus(Guid id)
        {
            try
            {
                var param = new { Id = id };

                _dataAccess.ManageData(SpTicketStatus.SpDeleteTicketStatus, param, CnnStringConfig.BugTrackerCnnString);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void UpdateTicketStatus(TicketStatusModel type)
        {
            try
            {
                _dataAccess.ManageData(SpTicketStatus.SpUpdateTicketStatus, type, CnnStringConfig.BugTrackerCnnString);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TicketStatusModel> GetCustomStatuses()
        {
            try
            {
                var output = _dataAccess.LoadData<TicketStatusModel, dynamic>(SpTicketStatus.SpGetCustomStatuses, new { },
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
