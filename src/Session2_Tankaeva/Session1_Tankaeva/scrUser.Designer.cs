namespace Session1_Tankaeva
{
    partial class scrUser
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.activityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.session1_TankaevaDataSet = new Session1_Tankaeva.Session1_TankaevaDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activityTableAdapter = new Session1_Tankaeva.Session1_TankaevaDataSetTableAdapters.ActivityTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.session2_TankaevaDataSet = new Session1_Tankaeva.Session2_TankaevaDataSet();
            this.trackingTableAdapter = new Session1_Tankaeva.Session2_TankaevaDataSetTableAdapters.TrackingTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1_TankaevaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session2_TankaevaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time spent on system:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of crashes: ";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.iDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.logInDataGridViewTextBoxColumn,
            this.Column2,
            this.reasonDataGridViewTextBoxColumn,
            this.logOutDataGridViewTextBoxColumn,
            this.Column3});
            this.dataGridView1.DataSource = this.trackingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(544, 174);
            this.dataGridView1.TabIndex = 3;
            // 
            // activityBindingSource1
            // 
            this.activityBindingSource1.DataMember = "Activity";
            this.activityBindingSource1.DataSource = this.session1_TankaevaDataSet;
            // 
            // session1_TankaevaDataSet
            // 
            this.session1_TankaevaDataSet.DataSetName = "Session1_TankaevaDataSet";
            this.session1_TankaevaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(12, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataMember = "Activity";
            this.activityBindingSource.DataSource = this.session1_TankaevaDataSet;
            // 
            // activityTableAdapter
            // 
            this.activityTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Logout";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Time spent";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // logInDataGridViewTextBoxColumn
            // 
            this.logInDataGridViewTextBoxColumn.DataPropertyName = "LogIn";
            this.logInDataGridViewTextBoxColumn.HeaderText = "Login";
            this.logInDataGridViewTextBoxColumn.Name = "logInDataGridViewTextBoxColumn";
            this.logInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "Reason";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            this.reasonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logOutDataGridViewTextBoxColumn
            // 
            this.logOutDataGridViewTextBoxColumn.DataPropertyName = "LogOut";
            this.logOutDataGridViewTextBoxColumn.HeaderText = "LogOut";
            this.logOutDataGridViewTextBoxColumn.Name = "logOutDataGridViewTextBoxColumn";
            this.logOutDataGridViewTextBoxColumn.ReadOnly = true;
            this.logOutDataGridViewTextBoxColumn.Visible = false;
            // 
            // trackingBindingSource
            // 
            this.trackingBindingSource.DataMember = "Tracking";
            this.trackingBindingSource.DataSource = this.session2_TankaevaDataSet;
            // 
            // session2_TankaevaDataSet
            // 
            this.session2_TankaevaDataSet.DataSetName = "Session2_TankaevaDataSet";
            this.session2_TankaevaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trackingTableAdapter
            // 
            this.trackingTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // scrUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(611, 316);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "scrUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amonic User";
            this.Load += new System.EventHandler(this.ScrUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1_TankaevaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session2_TankaevaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private Session1_TankaevaDataSet session1_TankaevaDataSet;
        private System.Windows.Forms.BindingSource activityBindingSource;
        private Session1_TankaevaDataSetTableAdapters.ActivityTableAdapter activityTableAdapter;
        private System.Windows.Forms.BindingSource activityBindingSource1;
        private Session2_TankaevaDataSet session2_TankaevaDataSet;
        private System.Windows.Forms.BindingSource trackingBindingSource;
        private Session2_TankaevaDataSetTableAdapters.TrackingTableAdapter trackingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label4;
    }
}