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
    public class TicketTypeData : ITicketTypeData
    {
        private readonly ISqlDataAccess _dataAccess;

        public TicketTypeData(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void CreateTicketType(TicketTypeModel type)
        {
            try
            {
                _dataAccess.ManageData(SpTicketType.SpCreateTicketType, type, CnnStringConfig.BugTrackerCnnString);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void DeleteTicketType(Guid id)
        {
            try
            {
                var param = new { Id = id };

                _dataAccess.ManageData(SpTicketType.SpDeleteTicketType, param, CnnStringConfig.BugTrackerCnnString);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void UpdateTicketType(TicketTypeModel type)
        {
            try
            {
                _dataAccess.ManageData(SpTicketType.SpUpdateTicketType, type, CnnStringConfig.BugTrackerCnnString);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TicketTypeModel> GetCustomTypes()
        {
            try
            {
                var output = _dataAccess.LoadData<TicketTypeModel, dynamic>(SpTicketType.SpGetCustomTypes, new { },
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
