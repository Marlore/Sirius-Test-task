using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Desktop.View
{
    public partial class TableView : Form, ITableView
    {
        public event Action UpdateProject;
        Dictionary<int, ComboBox> comboBoxesDistincValues;
        public TableView()
        {
            InitializeComponent();
            comboBoxesDistincValues = new Dictionary<int, ComboBox>();
        }

        public void AddItemToTable(DataSet employee)
        {
            MainTable.DataSource = employee.Tables[0];
            foreach (DataGridViewColumn column in MainTable.Columns)
            {
                column.ReadOnly = true;

            }
            AddFilters();
        }
        public void AddFilters()
        {
            for (int i = 0; i < MainTable.Columns.Count; i++)
            {
                var DistValues = MainTable.Rows.Cast<DataGridViewRow>()
                          .Where(x => !x.IsNewRow)                   // either..
                          .Where(x => x.Cells[i].Value != null) //..or or both
                          .Select(x => x.Cells[i].Value.ToString())
                          .Distinct()
                          .ToList();
                var comboBox = new ComboBox();
                comboBox.FormattingEnabled = true;
                comboBox.Location = new Point(50 + 100 * i, 20);
                comboBox.Name = "comboBox" + i;
                comboBox.Size = new Size(100, 23);
                comboBox.Items.Add("");
                foreach (var value in DistValues)
                {
                    comboBox.Items.Add(value);
                }
                comboBox.SelectedIndexChanged += new System.EventHandler(ChooseFilter);
                comboBoxesDistincValues.Add(i, comboBox);
                Controls.Add(comboBox);
            }
        }
        public void ChooseFilter(object sender,
        System.EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            int index = comboBoxesDistincValues.First(x => x.Value.Name == comboBox.Name).Key;
            string selectedFilter = comboBox.SelectedItem.ToString();
            MainTable.CurrentCell = null;
            for (int i = 0; i < MainTable.Rows.Count - 1; i++)
            {
                if (MainTable.Rows[i].Cells[index].Value.ToString() != selectedFilter)
                    MainTable.Rows[i].Visible = false;
            }
            
        }

        public new void Show()
        {
            this.Visible = true;
            UpdateProject.Invoke();
        }

        private void ClearFilter_Click(object sender, EventArgs e)
        {
            foreach (var comboBoxFilter in comboBoxesDistincValues)
            {
                comboBoxFilter.Value.SelectedIndex = 0;
            }
            for (int i = 0; i < MainTable.Rows.Count - 1; i++)
            {
                MainTable.Rows[i].Visible = true;
            }
        }
    }
}
