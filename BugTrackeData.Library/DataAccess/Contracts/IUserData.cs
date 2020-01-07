using BugTrackeData.Library.Models;
using System;
using System.Collections.Generic;

namespace BugTrackeData.Library.DataAccess.Contracts
{
    public interface IUserData
    {
        void CreateUser(UserModel project);
        void DeleteUser(Guid id);
        List<UserModel> GetAllUsers();
        UserData GetUser(Guid id);
        void UpdateUser(UserModel project);
    }
}