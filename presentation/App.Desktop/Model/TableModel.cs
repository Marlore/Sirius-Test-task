using App.Memory;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Desktop.Model
{
    public class TableModel:IModel
    {
        public EmployeeRepository employeeRepository{get;}
        string ServerPath;
        string DatabasePath;
        string TablePath;
        public TableModel(string serverPath, string databasePath, string tablePath)
        {
            employeeRepository = new EmployeeRepository();
            ServerPath = serverPath;
            DatabasePath = databasePath;
            TablePath = tablePath;
        }
        public void UpdateModel()
        {
            string dataPath = $"Server={ServerPath};Database={DatabasePath};Trusted_Connection=True;";
            string getTableExpression = $"SELECT * FROM {TablePath}";
            using (SqlConnection connection = new SqlConnection(dataPath))
            {                
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(getTableExpression,connection))
                {
                    adapter.Fill(employeeRepository.ListOfEmployees);    
                    connection.Close();
                }

            }
        }

    }
}
