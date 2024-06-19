using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Desktop.View
{
    public partial class DatabaseConnectionView : Form, IConnectionView
    {
        public event Action Connect;
        public DatabaseConnectionView()
        {
            InitializeComponent();
        }
        public new void Show()
        {
            Application.Run(this);
        }
        public new void Close()
        {
            this.Hide();
        }
        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public (string, string,string) GetStringPaths()
        {
            return (ServerText.Text, DatabaseText.Text, TableText.Text);
        }
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            Connect.Invoke();
        }
    }
}
