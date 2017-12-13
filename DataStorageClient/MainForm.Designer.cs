namespace DataStorageClient
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conductor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dispatcher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Route = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.routeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.conductorComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dispatcherComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Получить срез";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Driver,
            this.Conductor,
            this.Dispatcher,
            this.Route,
            this.StartTime,
            this.FinishTime});
            this.dataGridView1.Location = new System.Drawing.Point(31, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(678, 200);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Driver
            // 
            this.Driver.HeaderText = "Водитель";
            this.Driver.Name = "Driver";
            this.Driver.ReadOnly = true;
            // 
            // Conductor
            // 
            this.Conductor.HeaderText = "Кондуктор";
            this.Conductor.Name = "Conductor";
            this.Conductor.ReadOnly = true;
            // 
            // Dispatcher
            // 
            this.Dispatcher.HeaderText = "Диспетчер";
            this.Dispatcher.Name = "Dispatcher";
            this.Dispatcher.ReadOnly = true;
            // 
            // Route
            // 
            this.Route.HeaderText = "Номер маршрута";
            this.Route.Name = "Route";
            this.Route.ReadOnly = true;
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "Отправился";
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            // 
            // FinishTime
            // 
            this.FinishTime.HeaderText = "Время прибытия";
            this.FinishTime.Name = "FinishTime";
            this.FinishTime.ReadOnly = true;
            // 
            // driverComboBox
            // 
            this.driverComboBox.FormattingEnabled = true;
            this.driverComboBox.Location = new System.Drawing.Point(144, 10);
            this.driverComboBox.Name = "driverComboBox";
            this.driverComboBox.Size = new System.Drawing.Size(279, 21);
            this.driverComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Водителя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер маршрута";
            // 
            // routeComboBox
            // 
            this.routeComboBox.FormattingEnabled = true;
            this.routeComboBox.Location = new System.Drawing.Point(144, 137);
            this.routeComboBox.Name = "routeComboBox";
            this.routeComboBox.Size = new System.Drawing.Size(279, 21);
            this.routeComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Кондуктор";
            // 
            // conductorComboBox
            // 
            this.conductorComboBox.FormattingEnabled = true;
            this.conductorComboBox.Location = new System.Drawing.Point(145, 90);
            this.conductorComboBox.Name = "conductorComboBox";
            this.conductorComboBox.Size = new System.Drawing.Size(278, 21);
            this.conductorComboBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Диспетчер";
            // 
            // dispatcherComboBox
            // 
            this.dispatcherComboBox.FormattingEnabled = true;
            this.dispatcherComboBox.Location = new System.Drawing.Point(144, 50);
            this.dispatcherComboBox.Name = "dispatcherComboBox";
            this.dispatcherComboBox.Size = new System.Drawing.Size(279, 21);
            this.dispatcherComboBox.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(518, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "Получить прибыль по маршруту";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 381);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dispatcherComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.conductorComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.routeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.driverComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox driverComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox routeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox conductorComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox dispatcherComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Driver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conductor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dispatcher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Route;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishTime;
        private System.Windows.Forms.Button button2;
    }
}

