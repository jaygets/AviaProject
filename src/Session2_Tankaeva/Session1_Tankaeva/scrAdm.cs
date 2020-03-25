using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1_Tankaeva
{
    public partial class scrAdm : Form
    {
        string email;
        public scrAdm(string login)
        {
            InitializeComponent();
            email = login;
            


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //запись в трэкинг выхода из системы
            DataT DataT = new DataT();
            DataTable dt_user = DataT.Select("SELECT * FROM [dbo].[Users] WHERE [Email] =" +
                       " '" + email + "'");
            DataTable dt_trackID = DataT.Select("Select MAX(ID) FROM [dbo].[Tracking] WHERE UserID = '"+ dt_user.Rows[0][0].ToString() + "'");
            DataTable dt_track = DataT.Select("UPDATE [dbo].[Tracking] SET LogOut = '" + DateTime.Now + "'" +
                " WHERE [ID] ='" + dt_trackID.Rows[0][0].ToString() + "'");

            this.Close();

        }

        private void ScrAdm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "session2_TankaevaDataSet.Offices". При необходимости она может быть перемещена или удалена.
            this.officesTableAdapter1.Fill(this.session2_TankaevaDataSet.Offices);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "session2_TankaevaDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter1.Fill(this.session2_TankaevaDataSet.Users);

            FillGrid();
        }
        void FillGrid()
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataT DataT = new DataT();

                //определение ролей
                DataTable dt_roles = DataT.Select("SELECT * FROM [dbo].[Roles]");
                if (dt_roles.Rows.Count > 0)
                {
                    for (int r = 0; r < dt_roles.Rows.Count; r++)
                    {
                        if (dataGridView1.Rows[i].Cells[6].Value.ToString() == dt_roles.Rows[r][0].ToString())
                        {
                            dataGridView1.Rows[i].Cells[3].Value = dt_roles.Rows[r][1].ToString();
                        }
                    }
                }

                //офис, опредление офиса
                DataTable dt_office = DataT.Select("SELECT * FROM [dbo].[Offices]");
                if (dt_office.Rows.Count > 0)
                {
                    for (int j = 0; j < dt_office.Rows.Count; j++)
                        if (dataGridView1.Rows[i].Cells[8].Value.ToString() == dt_office.Rows[j][0].ToString())
                        {
                            dataGridView1.Rows[i].Cells[5].Value = dt_office.Rows[j][2].ToString();
                        }
                }

                //подсчет возраста
                DateTime d2 = Convert.ToDateTime(DateTime.Now);
                DateTime d1 = Convert.ToDateTime(dataGridView1.Rows[i].Cells[7].Value);

                dataGridView1.Rows[i].Cells[2].Value = (Math.Round(((d2 - d1).TotalDays / 365), 0));

                if (dataGridView1.Rows[i].Cells[9].Value.ToString() == "False")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 46, 46);
                }

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            NewUser newUser = new NewUser();
            newUser.ShowDialog();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int row = Convert.ToInt32(comboBox1.SelectedIndex);
            DataT DataT = new DataT();
            DataTable dt_office = DataT.Select("SELECT * FROM [dbo].[Offices]");
            if (row != -1)
            {
                this.usersTableAdapter1.FillBy(this.session2_TankaevaDataSet.Users, Convert.ToInt32(dt_office.Rows[row][0]));
                MessageBox.Show("Офис успешно отфильтрован", "Внимание!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            FillGrid();
        }

        private void NoFilter_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            this.usersTableAdapter1.Fill(this.session2_TankaevaDataSet.Users);
            FillGrid();
            MessageBox.Show("Фильтр успешно снят", "Внимание!",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //enable/disable
        private void Button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string temp;
                if (dataGridView1.Rows[row.Index].Cells[9].Value.ToString() == "False")
                {
                    temp = "True";
                }
                else
                {
                    temp = "False";
                }
                DataT DataT = new DataT();
                DataTable dt_users = DataT.Select("UPDATE [dbo].[Users] SET [Active] = '" + temp + "' Where " +
                    "ID = '" + dataGridView1.Rows[row.Index].Cells[10].Value.ToString() + "'");
                this.usersTableAdapter1.Fill(this.session2_TankaevaDataSet.Users);
                FillGrid();
                MessageBox.Show("Успешно изменено", "Внимание!",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                try
                {
                    string email = dataGridView1.Rows[row.Index].Cells[4].Value.ToString();
                    EditRole editRole = new EditRole(email);
                    editRole.ShowDialog();
                    this.usersTableAdapter1.Fill(this.session2_TankaevaDataSet.Users);
                    FillGrid();
                }
                catch
                {
                    MessageBox.Show("Выберите одного пользователя", "Внимание!",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
