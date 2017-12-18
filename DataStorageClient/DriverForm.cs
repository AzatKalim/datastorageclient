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
    public partial class DriverForm : Form
    {
        DbWork db;
        public DriverForm(DbWork db)
        {
            this.db = db;
            InitializeComponent();
            driverComboBox.DataSource = db.GetDriversNames();
            startComboBox.DataSource = db.GetDatesStart();
            stopComboBox.DataSource = db.GetDatesFinish();
            dataGridView1.Rows.Add();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DriverForm_Load(object sender, EventArgs e)
        {
            routeComboBox.DataSource = db.GetRouteNumber();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string driver = driverComboBox.SelectedItem.ToString();
            DateTime start = (DateTime)startComboBox.SelectedItem;
            DateTime stop = (DateTime)stopComboBox.SelectedItem;
            var result = db.GetDriversProfit(driver, start, stop);
            if (dataGridView1.Rows.Count == 1)
            {
                dataGridView1.Rows.RemoveAt(1);
            }
            int rowNumber = dataGridView1.Rows.Add();
            dataGridView1.Rows[rowNumber].Cells["Profit"].Value = result.Item1;
            dataGridView1.Rows[rowNumber].Cells["TripCount"].Value = result.Item2;
            dataGridView1.Rows[rowNumber].Cells["PassCount"].Value = result.Item3;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int route = Convert.ToInt32(routeComboBox.SelectedItem.ToString());
            DateTime start = (DateTime)startComboBox.SelectedItem;
            DateTime stop = (DateTime)stopComboBox.SelectedItem;
            var result = db.GetRouteProfit(route, start, stop);
            if (dataGridView1.Rows.Count == 1)
            {
                dataGridView1.Rows.RemoveAt(1);
            }
            int rowNumber = dataGridView1.Rows.Add();
            dataGridView1.Rows[rowNumber].Cells["Profit"].Value = result.Item1;
            dataGridView1.Rows[rowNumber].Cells["TripCount"].Value = result.Item2;
            dataGridView1.Rows[rowNumber].Cells["PassCount"].Value = result.Item3;
        }
    }
}
