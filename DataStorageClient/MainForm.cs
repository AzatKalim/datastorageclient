using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataStorageClient
{
    public partial class MainForm : Form
    {
        DbWork dbwork;
        public MainForm()
        {
            InitializeComponent();
            dbwork = new DbWork();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            driverComboBox.DataSource = dbwork.GetDriversNames();
            dispatcherComboBox.DataSource = dbwork.GetDispatcherNames();
            conductorComboBox.DataSource = dbwork.GetConductorNames();
            routeComboBox.DataSource = dbwork.GetRouteNumber();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<trip> trips=dbwork.GetTrip(driverComboBox.SelectedItem.ToString(), dispatcherComboBox.SelectedItem.ToString(),
                            conductorComboBox.SelectedItem.ToString(), (int)routeComboBox.SelectedItem);
            dataGridView1.Visible = true;
            foreach (var item in trips)
	        {
                int rowNumber= dataGridView1.Rows.Add();
                dataGridView1.Rows[rowNumber].Cells["Driver"].Value = item.driver.name;
                dataGridView1.Rows[rowNumber].Cells["Conductor"].Value = item.conductor.Name;
                dataGridView1.Rows[rowNumber].Cells["Dispatcher"].Value = item.dispatcher.name;
                dataGridView1.Rows[rowNumber].Cells["Route"].Value = item.route.route_number;
                dataGridView1.Rows[rowNumber].Cells["StartTime"].Value = item.start_time;
                dataGridView1.Rows[rowNumber].Cells["FinishTime"].Value = item.finish_time;
	        }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var driverForm = new DriverForm(dbwork);
            driverForm.ShowDialog();
        }
    }
}
