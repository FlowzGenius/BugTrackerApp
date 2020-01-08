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
    public class TicketData : ITicketData
    {
        private readonly ISqlDataAccess _dataAccess;

        public TicketData(ISqlDataAccess dataAccess)
        {
            this._dataAccess = dataAccess;
        }

        public void CreateTicket(TicketModel project)
        {
            try
            {
                _dataAccess.ManageData(SpTicket.SpCreateTicket, project, CnnStringConfig.BugTrackerCnnString);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public List<TicketModel> GetAllTickets()
        {
            try
            {
                var output = _dataAccess.LoadData<TicketModel, dynamic>(SpTicket.SpGetAllTickets, new { }, CnnStringConfig.BugTrackerCnnString);

                return output;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteTicket(Guid id)
        {
            try
            {
                var param = new { Id = id };

                _dataAccess.ManageData<dynamic>(SpTicket.SpDeleteTicketById, param, CnnStringConfig.BugTrackerCnnString);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public TicketData GetTicket(Guid id)
        {
            try
            {
                var param = new { Id = id };

                var output = _dataAccess.GetObject<TicketData, dynamic>(SpTicket.SpGetTicketById, param, CnnStringConfig.BugTrackerCnnString);

                return output;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void UpdateTicket(TicketModel project)
        {

            try
            {
                _dataAccess.ManageData(SpTicket.SpUpdateTicket, project, CnnStringConfig.BugTrackerCnnString);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
