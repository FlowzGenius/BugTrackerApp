using BugTrackeData.Library.Models;
using System.Collections.Generic;

namespace BugTrackeData.Library.Internal.DataAccess.Contracts
{
    public interface ISqlDataAccess
    {
        List<T> LoadData<T, U>(string storedProcedure, U parameters, string connectionStringName);
        void ManageData<T>(string storedProcedure, T parametres, string connectionStringName);
        T GetObject<T, U>(string storedProcedure, U parameters, string connectionStringName)
void ManageData(object spUser, UserModel project, string v);
    }
}