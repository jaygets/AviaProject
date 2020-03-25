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
    public partial class EditRole : Form
    {
        string email;
        public EditRole(string mail)
        {
            InitializeComponent();
            email = mail;
            DataT DataT = new DataT();
            DataTable dt_user = DataT.Select("SELECT * FROM [dbo].[Users] WHERE [Email] =" +
                " '" + email + "'");
            if (dt_user.Rows.Count > 0)
            {
                textBox1.Text = dt_user.Rows[0][2].ToString();
                textBox3.Text = dt_user.Rows[0][4].ToString();
                textBox4.Text = dt_user.Rows[0][5].ToString();

                //офис, опредление офиса
                DataTable dt_office = DataT.Select("SELECT * FROM [dbo].[Offices] WHERE ID = '" + dt_user.Rows[0][6].ToString() + "'");
                if (dt_office.Rows.Count > 0)
                {
                    textBox2.Text = dt_office.Rows[0][2].ToString();
                }

                if (dt_user.Rows[0][1].ToString() == "1")
                {
                    rbAdm.Checked = true;
                }
                else if (dt_user.Rows[0][1].ToString() == "2")
                {
                    rbUser.Checked = true;
                }
            }
           
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            string newId = "";
            try
            {            
            if (rbAdm.Checked == true)
            {
                newId = "1";
            }
            if (rbUser.Checked == true)
            {
                newId = "2";
            }
            DataT DataT = new DataT();
            DataTable dt_user = DataT.Select("UPDATE [dbo].[Users] SET RoleID = '"+ newId +"' WHERE [Email] ='" + email + "'");
                MessageBox.Show("Успешно изменено", "Внимание!",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Изменение не удалось. Выберите роль для сотрудника",
                         "Внимание!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void RbUser_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUser.Checked == true)
            {
                rbAdm.Checked = false;
            }
            if (rbAdm.Checked == true)
            {
                rbUser.Checked = false;
            }
        }

        private void RbAdm_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUser.Checked == true)
            {
                rbAdm.Checked = false;
            }
            if (rbAdm.Checked == true)
            {
                rbUser.Checked = false;
            }
        }

        private void BtnCncl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
