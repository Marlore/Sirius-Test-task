using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace App.Desktop.Service
{
    public interface IConnectionService
    {
        bool IsConnected(string serverString, string databaseString, string tableString);
    }
}
