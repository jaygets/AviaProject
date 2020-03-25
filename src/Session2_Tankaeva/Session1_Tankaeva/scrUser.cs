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
    public partial class scrUser : Form
    {
        string user;
        string _login;

        public scrUser(string login)
        {
            

            user = login;
            InitializeComponent();
            DataT DataT = new DataT();
            DataTable dt_user = DataT.Select("SELECT * FROM [dbo].[Users] WHERE [Email] =" +
                " '" + login + "'");
            if (dt_user.Rows.Count > 0)
            {
                label1.Text = "Hi " + dt_user.Rows[0][4] + ", Welcome to Amonic Airlines.";
            }
            
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //запись в трэкинг выхода из системы
            DataT DataT = new DataT();
            DataTable dt_user = DataT.Select("SELECT * FROM [dbo].[Users] WHERE [Email] =" +
                       " '" + user + "'");
            DataTable dt_trackID = DataT.Select("Select MAX(ID) FROM [dbo].[Tracking] WHERE UserID = '" + dt_user.Rows[0][0].ToString() + "'");
            DataTable dt_track = DataT.Select("UPDATE [dbo].[Tracking] SET LogOut = '" + DateTime.Now + "'" +
                " WHERE [ID] ='" + dt_trackID.Rows[0][0].ToString() + "'");
            this.Close();
           
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ScrUser_Load(object sender, EventArgs e)
        {
            int count = -1;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "session2_TankaevaDataSet.Tracking". При необходимости она может быть перемещена или удалена.
            this.trackingTableAdapter.FillBy(this.session2_TankaevaDataSet.Tracking,user);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[0].Value = row.Cells[3].Value.ToString().Split(' ')[0];
                _login = row.Cells[3].Value.ToString();
                row.Cells[3].Value = _login.Split(' ')[1];
                if (row.Cells[5].Value.ToString() != "")
                {
                    row.Cells[4].Value = "***";
                    row.Cells[7].Value = "***";
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 46, 46);
                    count++;
                }
                else
                { try
                    {
                        row.Cells[4].Value = row.Cells[6].Value.ToString().Split(' ')[1];
                        var diff = (Convert.ToDateTime(row.Cells[6].Value) - Convert.ToDateTime(row.Cells[3].Value)).Duration();
                        row.Cells[7].Value = diff.Hours + ":"+ diff.Minutes + ":" + diff.Seconds;
                    }
                    catch
                    {
                        //скрываем строку со входом в данных момент
                        row.Cells[0].Style.ForeColor = Color.White;
                        row.Cells[3].Style.ForeColor = Color.White;
                        row.Cells[5].Style.ForeColor = Color.White;
                        row.Cells[4].Style.ForeColor = Color.White;
                        row.Cells[7].Style.ForeColor = Color.White;              
                        count++;
                    }
                }
               
            }

            Timer timer1 = new Timer();
            label3.Text += count;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            timer1.Enabled = true;


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // отсчет времени проведенного в системе
            var diff = DateTime.Now - Convert.ToDateTime(_login);
            label4.Text = diff.Hours + ":" + diff.Minutes + ":" + diff.Seconds;
        }
    }
}
