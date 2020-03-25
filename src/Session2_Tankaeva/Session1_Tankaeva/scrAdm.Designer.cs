namespace Session1_Tankaeva
{
    partial class scrAdm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Office = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.session2_TankaevaDataSet = new Session1_Tankaeva.Session2_TankaevaDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.session1_TankaevaDataSet = new Session1_Tankaeva.Session1_TankaevaDataSet();
            this.btnChange = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.officesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.officesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Session1_Tankaeva.Session1_TankaevaDataSetTableAdapters.UsersTableAdapter();
            this.officesTableAdapter = new Session1_Tankaeva.Session1_TankaevaDataSetTableAdapters.OfficesTableAdapter();
            this.usersTableAdapter1 = new Session1_Tankaeva.Session2_TankaevaDataSetTableAdapters.UsersTableAdapter();
            this.officesTableAdapter1 = new Session1_Tankaeva.Session2_TankaevaDataSetTableAdapters.OfficesTableAdapter();
            this.NoFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session2_TankaevaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1_TankaevaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(108, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2,
            this.emailDataGridViewTextBoxColumn,
            this.Office,
            this.roleIDDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn,
            this.officeIDDataGridViewTextBoxColumn,
            this.Active,
            this.ID});
            this.dataGridView1.DataSource = this.usersBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 248);
            this.dataGridView1.TabIndex = 2;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Age";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "User Role";
            this.Column2.Name = "Column2";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // Office
            // 
            this.Office.HeaderText = "Office";
            this.Office.Name = "Office";
            // 
            // roleIDDataGridViewTextBoxColumn
            // 
            this.roleIDDataGridViewTextBoxColumn.DataPropertyName = "RoleID";
            this.roleIDDataGridViewTextBoxColumn.HeaderText = "RoleID";
            this.roleIDDataGridViewTextBoxColumn.Name = "roleIDDataGridViewTextBoxColumn";
            this.roleIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            this.birthdateDataGridViewTextBoxColumn.Visible = false;
            // 
            // officeIDDataGridViewTextBoxColumn
            // 
            this.officeIDDataGridViewTextBoxColumn.DataPropertyName = "OfficeID";
            this.officeIDDataGridViewTextBoxColumn.HeaderText = "OfficeID";
            this.officeIDDataGridViewTextBoxColumn.Name = "officeIDDataGridViewTextBoxColumn";
            this.officeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.Visible = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.session2_TankaevaDataSet;
            // 
            // session2_TankaevaDataSet
            // 
            this.session2_TankaevaDataSet.DataSetName = "Session2_TankaevaDataSet";
            this.session2_TankaevaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.session1_TankaevaDataSet;
            // 
            // session1_TankaevaDataSet
            // 
            this.session1_TankaevaDataSet.DataSetName = "Session1_TankaevaDataSet";
            this.session1_TankaevaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.SystemColors.Control;
            this.btnChange.Location = new System.Drawing.Point(12, 369);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(118, 41);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Change role";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(150, 369);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(201, 41);
            this.button4.TabIndex = 4;
            this.button4.Text = "Enable/Disable login";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Office:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.officesBindingSource1;
            this.comboBox1.DisplayMember = "Title";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(75, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // officesBindingSource1
            // 
            this.officesBindingSource1.DataMember = "Offices";
            this.officesBindingSource1.DataSource = this.session2_TankaevaDataSet;
            // 
            // officesBindingSource
            // 
            this.officesBindingSource.DataMember = "Offices";
            this.officesBindingSource.DataSource = this.session1_TankaevaDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // officesTableAdapter
            // 
            this.officesTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // officesTableAdapter1
            // 
            this.officesTableAdapter1.ClearBeforeFill = true;
            // 
            // NoFilter
            // 
            this.NoFilter.Location = new System.Drawing.Point(223, 69);
            this.NoFilter.Name = "NoFilter";
            this.NoFilter.Size = new System.Drawing.Size(128, 28);
            this.NoFilter.TabIndex = 7;
            this.NoFilter.Text = "Remove filter";
            this.NoFilter.UseVisualStyleBackColor = true;
            this.NoFilter.Click += new System.EventHandler(this.NoFilter_Click);
            // 
            // scrAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(688, 426);
            this.Controls.Add(this.NoFilter);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "scrAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amonic";
            this.Load += new System.EventHandler(this.ScrAdm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session2_TankaevaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1_TankaevaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Session1_TankaevaDataSet session1_TankaevaDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Session1_TankaevaDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource officesBindingSource;
        private Session1_TankaevaDataSetTableAdapters.OfficesTableAdapter officesTableAdapter;
        private Session2_TankaevaDataSet session2_TankaevaDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private Session2_TankaevaDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.BindingSource officesBindingSource1;
        private Session2_TankaevaDataSetTableAdapters.OfficesTableAdapter officesTableAdapter1;
        private System.Windows.Forms.Button NoFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Office;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}