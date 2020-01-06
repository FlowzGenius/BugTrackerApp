using BugTrackeData.Library.Internal.DataAccess.Contracts;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BugTrackeData.Library.Internal.DataAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private string GetConnecctionString(string connectionStringName)
        {
            string connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;

            return connectionString;
        }

        public List<T> LoadData<T, U>(string storedProcedure, U parameters, string connectionStringName)
        {
            string connectionString = GetConnecctionString(connectionStringName);

            using (IDbConnection cnn = new SqlConnection(connectionString))
            {
                var output = cnn.Query<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure).AsList();

                return output;
            }
        }

        public void SaveData<T>(string storedProcedure, T parametres, string connectionStringName)
        {
            string connectionString = GetConnecctionString(connectionStringName);

            using (IDbConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Execute(storedProcedure, parametres, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
