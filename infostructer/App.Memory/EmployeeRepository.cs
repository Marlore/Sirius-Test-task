using System.Data;

namespace App.Memory
{
    public class EmployeeRepository:IEmployeeRepository
    {
        public DataSet ListOfEmployees { get; }
        public EmployeeRepository()
        {
            ListOfEmployees = new DataSet();
        }

    }
}
