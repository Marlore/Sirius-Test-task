using App.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Desktop.Model
{
    public interface IModel
    {
        public EmployeeRepository employeeRepository { get; }
        public void UpdateModel();
    }
}
