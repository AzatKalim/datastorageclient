namespace DataStorageClient
{
    partial class DriverForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.driverComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stopComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TripCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Profit,
            this.TripCount,
            this.PassCount});
            this.dataGridView1.Location = new System.Drawing.Point(36, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 103);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // driverComboBox
            // 
            this.driverComboBox.FormattingEnabled = true;
            this.driverComboBox.Location = new System.Drawing.Point(136, 34);
            this.driverComboBox.Name = "driverComboBox";
            this.driverComboBox.Size = new System.Drawing.Size(194, 21);
            this.driverComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Водитель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата начала";
            // 
            // startComboBox
            // 
            this.startComboBox.FormattingEnabled = true;
            this.startComboBox.Location = new System.Drawing.Point(136, 68);
            this.startComboBox.Name = "startComboBox";
            this.startComboBox.Size = new System.Drawing.Size(194, 21);
            this.startComboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата окончания";
            // 
            // stopComboBox
            // 
            this.stopComboBox.FormattingEnabled = true;
            this.stopComboBox.Location = new System.Drawing.Point(136, 102);
            this.stopComboBox.Name = "stopComboBox";
            this.stopComboBox.Size = new System.Drawing.Size(194, 21);
            this.stopComboBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Profit
            // 
            this.Profit.HeaderText = "Прибыль";
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            // 
            // TripCount
            // 
            this.TripCount.HeaderText = "Число рейсов";
            this.TripCount.Name = "TripCount";
            this.TripCount.ReadOnly = true;
            // 
            // PassCount
            // 
            this.PassCount.HeaderText = "Число пассажиров";
            this.PassCount.Name = "PassCount";
            this.PassCount.ReadOnly = true;
            // 
            // DriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stopComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.driverComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DriverForm";
            this.Text = "DriverForm";
            this.Load += new System.EventHandler(this.DriverForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox driverComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox startComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox stopComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassCount;
    }
}