using App.Desktop.Model;
using App.Desktop.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace App.Desktop.Presenter
{
    public class TablePresenter: IPresenter
    {
        public IModel _model = null;
        public ITableView _view = null;
        public TablePresenter(ITableView view, IModel model)
        {
            _view = view;
            _model = model;
            _model.UpdateModel();

            _view.UpdateProject +=()=> UpdateTable();
        }
        public void Run()
        {
            _view.Show();
        }
        public void UpdateTable()
        {
            _view.AddItemToTable(_model.employeeRepository.ListOfEmployees);
        }
    }
}
