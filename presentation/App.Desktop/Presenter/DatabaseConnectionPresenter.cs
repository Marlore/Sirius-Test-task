using App.Desktop.Model;
using App.Desktop.Service;
using App.Desktop.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Desktop.Presenter
{
    public class DatabaseConnectionPresenter:IPresenter
    {
        public IConnectionView _view;
        public IConnectionService _service;
        public DatabaseConnectionPresenter(IConnectionView view, IConnectionService service)
        {
            _view = view;
            _service = service;

            _view.Connect += () => Connect();
        }
        

        public void Run()
        {
            _view.Show();
        }
        public void Connect()
        {
            if (_service.IsConnected(_view.GetStringPaths().Item1, _view.GetStringPaths().Item2, _view.GetStringPaths().Item3))
            {
                var tablePresenter = new TablePresenter(new TableView(), new TableModel(_view.GetStringPaths().Item1, _view.GetStringPaths().Item2, _view.GetStringPaths().Item3));
                _view.Close();
                tablePresenter.Run();
            }
            else
            {
                _view.ShowError("Invalid server name or database name or table name");
            }
        }
    }
}
