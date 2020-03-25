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
    public partial class schdlEd : Form
    {
        string id;
        public schdlEd(string _id, string from, string to, string air)
        {
            InitializeComponent();
            id = _id;
            label2.Text = from;
            label4.Text = to;
            label6.Text = air;
            DataT DataT = new DataT();
            DataTable dt_schdls = DataT.Select("SELECT * FROM [dbo].[Schedules] WHERE [ID] =" +
                " '" + id + "'");
            if (dt_schdls.Rows.Count > 0)
            {
                textBox1.Text = dt_schdls.Rows[0][1].ToString();
                textBox3.Text = dt_schdls.Rows[0][5].ToString();
                textBox2.Text = dt_schdls.Rows[0][2].ToString();
            }

            }

        private void SchdlEd_Load(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
            DataT DataT = new DataT();
            DataTable dt_schdls = DataT.Select("UPDATE [dbo].[Schedules] SET Date = '"+ Convert.ToDateTime(textBox1.Text) + "'," +
                " Time = '" + Convert.ToDateTime(textBox2.Text) + "', EconomyPrice ='" + textBox3.Text +"' WHERE [ID] =" +
                " '" + id + "'");
            MessageBox.Show("Updated succesfully", "Info",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Cant update. Check entered format", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
