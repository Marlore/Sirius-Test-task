using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Desktop.View
{
    public interface IView
    {
        public void Show();
        public void Close();
    }
    public interface ITableView:IView 
    {

        public event Action UpdateProject;
        public void AddItemToTable(DataSet employee);
        public void AddFilters();
        public void ChooseFilter(object sender,System.EventArgs e);
    }
    public interface IConnectionView : IView
    {
        event Action Connect;
        public void ShowError(string message);
        public (string, string, string) GetStringPaths();
    }
  

}
