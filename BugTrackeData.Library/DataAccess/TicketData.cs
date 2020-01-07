using BugTrackeData.Library.DataAccess.Contracts;
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
                _dataAccess.ManageData("dbo.spCreateTicket", project, "BugTrackerData");
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
                var output = _dataAccess.LoadData<TicketModel, dynamic>("dbo.spGetAllTickets", new { }, "BugTrackerData");

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

                _dataAccess.ManageData<dynamic>("dbo.spDeleteTicketById", param, "BugTrackerData");
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

                var output = _dataAccess.GetObject<TicketData, dynamic>("dbo.spGetTicketById", param, "BugTrackerData");

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
                _dataAccess.ManageData("dbo.spUpdateTicket", project, "BugTrackerData");
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
