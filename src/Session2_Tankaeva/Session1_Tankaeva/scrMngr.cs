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
    public partial class scrMngr : Form
    {
        string email;
        public scrMngr(string login)
        {
            email = login;
            InitializeComponent();
           
        }

        private void ScrMngr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "session2_TankaevaDataSet1.Schedules". При необходимости она может быть перемещена или удалена.
            this.schedulesTableAdapter.Fill(this.session2_TankaevaDataSet1.Schedules);
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "session2_TankaevaDataSet.Airports". При необходимости она может быть перемещена или удалена.
            this.airportsTableAdapter.Fill(this.session2_TankaevaDataSet.Airports);
           

            cbFrom.Text = "";
            cbTo.Text = "";
            cbSort.Text = "";
            setData();
            btnRem.Visible = false;
        }
        //преобразования данных из таблицы в датагрид
        void setData()
        { 
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                DataT DataT = new DataT();
                DataTable dt_airports = DataT.Select("SELECT * FROM [dbo].[Airports]");
                if (dt_airports.Rows.Count > 0)
                {
                    for (int j = 0; j < dt_airports.Rows.Count; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[3].Value != null)
                        {
                            if (dataGridView1.Rows[i].Cells[3].Value.ToString() == dt_airports.Rows[j][0].ToString())
                            {
                                dataGridView1.Rows[i].Cells[4].Value = dt_airports.Rows[j][2].ToString();
                            }
                        }
                        if (dataGridView1.Rows[i].Cells[5].Value != null)
                        {
                            if (dataGridView1.Rows[i].Cells[5].Value.ToString() == dt_airports.Rows[j][0].ToString())
                            {
                                dataGridView1.Rows[i].Cells[6].Value = dt_airports.Rows[j][2].ToString();
                            }
                        }
                    }

                }
                dataGridView1.Rows[i].Cells[10].Value = Math.Round(Convert.ToDouble(dataGridView1.Rows[i].Cells[10].Value), 0);
                dataGridView1.Rows[i].Cells[11].Value = Math.Round(Convert.ToDouble(dataGridView1.Rows[i].Cells[10].Value) * 1.35, 0);
                dataGridView1.Rows[i].Cells[12].Value = Math.Round(Convert.ToDouble(dataGridView1.Rows[i].Cells[11].Value) * 1.3, 0);
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[7].Value) == false)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 46, 46);
                }

            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //запись в трэкинг выхода из системы
            DataT DataT = new DataT();
            DataTable dt_user = DataT.Select("SELECT * FROM [dbo].[Users] WHERE [Email] =" +
                       " '" + email + "'");
            DataTable dt_trackID = DataT.Select("Select MAX(ID) FROM [dbo].[Tracking] WHERE UserID = '" + dt_user.Rows[0][0].ToString() + "'");
            DataTable dt_track = DataT.Select("UPDATE [dbo].[Tracking] SET LogOut = '" + DateTime.Now + "'" +
                " WHERE [ID] ='" + dt_trackID.Rows[0][0].ToString() + "'");

            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //возвращаем все как было
            schedulesBindingSource.Filter = null;
            this.schedulesTableAdapter.Fill(this.session2_TankaevaDataSet1.Schedules);
            setData();

            //применяем сортировку
            if (cbSort.Text != "")
            {
                if (cbSort.Text == "Price")
                {                
                    dataGridView1.Sort(dataGridView1.Columns["economyPriceDataGridViewTextBoxColumn"], ListSortDirection.Ascending);
                    setData();
                }
                if (cbSort.Text == "Confirmed")
                {
                    dataGridView1.Sort(dataGridView1.Columns["confirmedDataGridViewCheckBoxColumn"], ListSortDirection.Ascending);
                    setData();
                }
                if (cbSort.Text == "Date")
                {
                    dataGridView1.Sort(dataGridView1.Columns["dateDataGridViewTextBoxColumn"], ListSortDirection.Ascending);
                    setData();
                }
                MessageBox.Show("Sorted succesfully", "Info",
              MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            //применяем фильтры
            if (cbTo.Text != cbFrom.Text)
            {
                if (cbFrom.Text != "" & cbTo.Text == "")
                {
                    this.schedulesTableAdapter.FillBy10(this.session2_TankaevaDataSet1.Schedules, cbFrom.SelectedIndex + 2);
                }
                else if (cbFrom.Text == "" & cbTo.Text != "")
                {
                    this.schedulesTableAdapter.FillBy01(this.session2_TankaevaDataSet1.Schedules, cbTo.SelectedIndex + 2);
                }
                else if (cbFrom.Text != "" & cbTo.Text != "")
                {
                    this.schedulesTableAdapter.FillBy11(this.session2_TankaevaDataSet1.Schedules, cbFrom.SelectedIndex + 2, cbTo.SelectedIndex + 1);
                }
                setData();
                MessageBox.Show("Filtered succesfully", "Info",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (textBox2.Text != "" & textBox1.Text != "")
            {
                var dat = Convert.ToDateTime(textBox1.Text);
                schedulesBindingSource.Filter = "[FlightNumber] LIKE'" + textBox2.Text + "%' AND" +
                    " Convert(Date,'System.String') LIKE '" + dat + "%'";
                setData();
                MessageBox.Show("Filtered succesfully", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
            if (textBox2.Text != "")
            {
                schedulesBindingSource.Filter = "[FlightNumber] LIKE'" + textBox2.Text + "%'";
                setData();
                    MessageBox.Show("Filtered succesfully", "Info",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                if (textBox1.Text != "")
                {
                    var dat = Convert.ToDateTime(textBox1.Text);
                    schedulesBindingSource.Filter = "Convert(Date,'System.String') LIKE '" + dat + "%'";
                    setData();
                        MessageBox.Show("Filtered succesfully", "Info",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }           
            }
            //появляется кнопка отмены фильтра после его применения
            btnRem.Visible = true;
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //try
            //{
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                schdlEd schdlEd = new schdlEd(row.Cells[0].Value.ToString(),row.Cells[4].Value.ToString(),row.Cells[6].Value.ToString(), row.Cells[8].Value.ToString());
                schdlEd.ShowDialog();
                this.schedulesTableAdapter.Fill(this.session2_TankaevaDataSet1.Schedules);
                setData();
            }
            //}
            //catch
            //{
            //    MessageBox.Show("Select one row to edit a flight", "Info",
            // MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
           
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnRem_Click(object sender, EventArgs e)
        {
            //возвращаем все как было
            schedulesBindingSource.Filter = null;
            this.schedulesTableAdapter.Fill(this.session2_TankaevaDataSet1.Schedules);
            setData();
            cbFrom.Text = "";
            cbTo.Text = "";
            cbSort.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";

            //убираем кнопку
            btnRem.Visible = false;
            MessageBox.Show("Filteres & sort removed", "Info",
             MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnConf_Click(object sender, EventArgs e)
        {
            schedulesTableAdapter.Update(this.session2_TankaevaDataSet1);
            this.schedulesTableAdapter.Fill(this.session2_TankaevaDataSet1.Schedules);
            setData();
            MessageBox.Show("Confirmation accepted", "Info",
              MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            SchdlsChanges sChange = new SchdlsChanges();
            sChange.ShowDialog();
        }
    }
}
