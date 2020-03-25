namespace Session1_Tankaeva
{
    partial class scrMngr
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureAirportIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalAirportIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.economyPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schedulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.session2_TankaevaDataSet1 = new Session1_Tankaeva.Session2_TankaevaDataSet();
            this.session2_TankaevaDataSet = new Session1_Tankaeva.Session2_TankaevaDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnConf = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.airportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.airportsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.airportsTableAdapter = new Session1_Tankaeva.Session2_TankaevaDataSetTableAdapters.AirportsTableAdapter();
            this.schedulesTableAdapter = new Session1_Tankaeva.Session2_TankaevaDataSetTableAdapters.SchedulesTableAdapter();
            this.btnRem = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session2_TankaevaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session2_TankaevaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sort by";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Outbound";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Flight number";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.departureAirportIDDataGridViewTextBoxColumn,
            this.Column3,
            this.arrivalAirportIDDataGridViewTextBoxColumn,
            this.Column4,
            this.confirmedDataGridViewCheckBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.flightNumberDataGridViewTextBoxColumn,
            this.economyPriceDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2});
            this.dataGridView1.DataSource = this.schedulesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 148);
            this.dataGridView1.TabIndex = 5;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // departureAirportIDDataGridViewTextBoxColumn
            // 
            this.departureAirportIDDataGridViewTextBoxColumn.DataPropertyName = "DepartureAirportID";
            this.departureAirportIDDataGridViewTextBoxColumn.HeaderText = "Departure AirportID";
            this.departureAirportIDDataGridViewTextBoxColumn.Name = "departureAirportIDDataGridViewTextBoxColumn";
            this.departureAirportIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.departureAirportIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "From";
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // arrivalAirportIDDataGridViewTextBoxColumn
            // 
            this.arrivalAirportIDDataGridViewTextBoxColumn.DataPropertyName = "ArrivalAirportID";
            this.arrivalAirportIDDataGridViewTextBoxColumn.HeaderText = "ArrivalAirportID";
            this.arrivalAirportIDDataGridViewTextBoxColumn.Name = "arrivalAirportIDDataGridViewTextBoxColumn";
            this.arrivalAirportIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.arrivalAirportIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "To";
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // confirmedDataGridViewCheckBoxColumn
            // 
            this.confirmedDataGridViewCheckBoxColumn.DataPropertyName = "Confirmed";
            this.confirmedDataGridViewCheckBoxColumn.HeaderText = "Confirmed";
            this.confirmedDataGridViewCheckBoxColumn.Name = "confirmedDataGridViewCheckBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Aircraft";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // flightNumberDataGridViewTextBoxColumn
            // 
            this.flightNumberDataGridViewTextBoxColumn.DataPropertyName = "FlightNumber";
            this.flightNumberDataGridViewTextBoxColumn.HeaderText = "Flight Number";
            this.flightNumberDataGridViewTextBoxColumn.Name = "flightNumberDataGridViewTextBoxColumn";
            this.flightNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // economyPriceDataGridViewTextBoxColumn
            // 
            this.economyPriceDataGridViewTextBoxColumn.DataPropertyName = "EconomyPrice";
            this.economyPriceDataGridViewTextBoxColumn.HeaderText = "Economy price";
            this.economyPriceDataGridViewTextBoxColumn.Name = "economyPriceDataGridViewTextBoxColumn";
            this.economyPriceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Business";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "1st Class";
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // schedulesBindingSource
            // 
            this.schedulesBindingSource.DataMember = "Schedules";
            this.schedulesBindingSource.DataSource = this.session2_TankaevaDataSet1;
            // 
            // session2_TankaevaDataSet1
            // 
            this.session2_TankaevaDataSet1.DataSetName = "Session2_TankaevaDataSet";
            this.session2_TankaevaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // session2_TankaevaDataSet
            // 
            this.session2_TankaevaDataSet.DataSetName = "Session2_TankaevaDataSet";
            this.session2_TankaevaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(457, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Apply";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnConf
            // 
            this.btnConf.Location = new System.Drawing.Point(4, 333);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(203, 37);
            this.btnConf.TabIndex = 8;
            this.btnConf.Text = "Save confirmed flight";
            this.btnConf.UseVisualStyleBackColor = true;
            this.btnConf.Click += new System.EventHandler(this.BtnConf_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(213, 333);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 37);
            this.button4.TabIndex = 9;
            this.button4.Text = "Edit Flight";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // cbFrom
            // 
            this.cbFrom.DataSource = this.airportsBindingSource;
            this.cbFrom.DisplayMember = "IATACode";
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Location = new System.Drawing.Point(79, 59);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(121, 28);
            this.cbFrom.TabIndex = 10;
            this.cbFrom.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // airportsBindingSource
            // 
            this.airportsBindingSource.DataMember = "Airports";
            this.airportsBindingSource.DataSource = this.session2_TankaevaDataSet;
            // 
            // cbTo
            // 
            this.cbTo.DataSource = this.airportsBindingSource1;
            this.cbTo.DisplayMember = "IATACode";
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Location = new System.Drawing.Point(265, 59);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(121, 28);
            this.cbTo.TabIndex = 11;
            // 
            // airportsBindingSource1
            // 
            this.airportsBindingSource1.DataMember = "Airports";
            this.airportsBindingSource1.DataSource = this.session2_TankaevaDataSet;
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "Price",
            "Confirmed",
            "Data"});
            this.cbSort.Location = new System.Drawing.Point(457, 59);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(121, 28);
            this.cbSort.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(325, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 14;
            // 
            // airportsTableAdapter
            // 
            this.airportsTableAdapter.ClearBeforeFill = true;
            // 
            // schedulesTableAdapter
            // 
            this.schedulesTableAdapter.ClearBeforeFill = true;
            // 
            // btnRem
            // 
            this.btnRem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRem.Location = new System.Drawing.Point(559, 99);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(78, 29);
            this.btnRem.TabIndex = 15;
            this.btnRem.Text = "Remove";
            this.btnRem.UseVisualStyleBackColor = true;
            this.btnRem.Click += new System.EventHandler(this.BtnRem_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(589, 333);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(156, 37);
            this.btnChange.TabIndex = 16;
            this.btnChange.Text = "Import changes";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // scrMngr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(765, 386);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnRem);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.cbTo);
            this.Controls.Add(this.cbFrom);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnConf);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "scrMngr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Flight Schedules";
            this.Load += new System.EventHandler(this.ScrMngr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session2_TankaevaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session2_TankaevaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnConf;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private Session2_TankaevaDataSet session2_TankaevaDataSet;
        private System.Windows.Forms.BindingSource airportsBindingSource;
        private Session2_TankaevaDataSetTableAdapters.AirportsTableAdapter airportsTableAdapter;
        private System.Windows.Forms.BindingSource airportsBindingSource1;
        private Session2_TankaevaDataSet session2_TankaevaDataSet1;
        private System.Windows.Forms.BindingSource schedulesBindingSource;
        private Session2_TankaevaDataSetTableAdapters.SchedulesTableAdapter schedulesTableAdapter;
        private System.Windows.Forms.Button btnRem;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureAirportIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalAirportIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn confirmedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn economyPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnChange;
    }
}