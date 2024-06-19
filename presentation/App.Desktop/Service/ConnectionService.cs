using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Desktop.Service
{
    public class ConnectionService : IConnectionService
    {
        public bool IsConnected(string serverPath, string databasePath, string tablePath)
        {
            bool connectionOpen = false;
            string connectionString = $"Server={serverPath};Database={databasePath};Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            string expression = $"SELECT * FROM {tablePath}";
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(expression, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                connectionOpen = false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connectionOpen = true;
                    connection.Close();
                }
            }

            return connectionOpen;
        }
    }
}
