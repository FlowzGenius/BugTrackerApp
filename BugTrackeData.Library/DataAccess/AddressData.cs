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
    public class AddressData : IAddressData
    {
        private readonly ISqlDataAccess _dataAccess;

        public AddressData(ISqlDataAccess dataAccess)
        {
            this._dataAccess = dataAccess;
        }

        public void CreateAddress(AddressModel project)
        {
            try
            {
                _dataAccess.ManageData(SpUserAddress.SpCreateAddress, project, CnnStringConfig.BugTrackerCnnString);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void DeleteAddress(Guid id)
        {
            try
            {
                var param = new { Id = id };

                _dataAccess.ManageData<dynamic>(SpUserAddress.SpDeleteAddressById, param, CnnStringConfig.BugTrackerCnnString);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<AddressData> GetAddress(Guid userId)
        {
            try
            {
                var param = new { Id = userId };

                var output = _dataAccess.LoadData<AddressData, dynamic>(SpUserAddress.SpDeleteAddressById, param, CnnStringConfig.BugTrackerCnnString);

                return output;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void UpdateAddress(AddressModel project)
        {

            try
            {
                _dataAccess.ManageData(SpUserAddress.SpUpdateAddress, project, CnnStringConfig.BugTrackerCnnString);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
