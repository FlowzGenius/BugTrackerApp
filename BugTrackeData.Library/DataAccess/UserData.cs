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
    public class UserData : IUserData
    {
        private readonly ISqlDataAccess _dataAccess;

        public UserData(ISqlDataAccess dataAccess)
        {
            this._dataAccess = dataAccess;
        }

        public void CreateUser(UserModel project)
        {
            try
            {
                _dataAccess.ManageData(SpUserInformation.SpCreateUser, project, CnnStringConfig.BugTrackerCnnString);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public List<UserModel> GetAllUsers()
        {
            try
            {
                var output = _dataAccess.LoadData<UserModel, dynamic>(SpUserInformation.SpGetAllUsers, new { }, 
                    CnnStringConfig.BugTrackerCnnString);

                return output;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteUser(Guid id)
        {
            try
            {
                var param = new { Id = id };

                _dataAccess.ManageData<dynamic>(SpUserInformation.SpDeleteUserById, param, CnnStringConfig.BugTrackerCnnString);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public UserData GetUser(Guid id)
        {
            try
            {
                var param = new { Id = id };

                var output = _dataAccess.GetObject<UserData, dynamic>(SpUserInformation.SpGetUserById, param, CnnStringConfig.BugTrackerCnnString);

                return output;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void UpdateUser(UserModel project)
        {

            try
            {
                _dataAccess.ManageData(SpUserInformation.SpUpdateUser, project,CnnStringConfig.BugTrackerCnnString);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
