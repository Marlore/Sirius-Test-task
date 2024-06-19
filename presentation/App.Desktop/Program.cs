using App.Desktop.Model;
using App.Desktop.Presenter;
using App.Desktop.Service;
using App.Desktop.View;

namespace App.Desktop
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var presenter = new DatabaseConnectionPresenter(new DatabaseConnectionView(), new ConnectionService());
            presenter.Run();
        }
    }
}