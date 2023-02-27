using LibraryFromWorkToSql.Configurations;
using System;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace LibraryFromWorkToSql.Properties
{
    public class MainConnector
    {
        public async Task<bool> ConnectAsync()
        {
            bool result;
            try
            {
                var connection = new SqlConnection(ConnectionString.MsSqlConnection);
                await connection.OpenAsync();
                result = true;
            }
            catch
            {
                result = false;
            }

            return result;
        }
        public void DisconnectAsync()
        {
            var connection = new SqlConnection(ConnectionString.MsSqlConnection);
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public SqlConnection GetConnection()
        {
            var connection = new SqlConnection(ConnectionString.MsSqlConnection);

            if (connection.State == ConnectionState.Open)
            {
                return connection;
            }
            else
            {
                throw new Exception("Подключение уже закрыто!");
            }
        }
    }
}
