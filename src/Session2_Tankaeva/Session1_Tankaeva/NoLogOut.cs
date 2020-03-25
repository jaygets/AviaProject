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
    public partial class NoLogOut : Form
    {
        string ident;
        string reason = "Re:";
        public NoLogOut(string id, string logIn)
        {
            InitializeComponent();
            label1.Text = label1.Text + logIn;
            ident = id;
            //вносим в причину часть с re
            DataT DataT = new DataT();
            DataTable dt_track = DataT.Select("UPDATE [dbo].[Tracking] SET Reason = '"
                + reason + "', LogOut = '" + DateTime.Now + "'" +
             " WHERE [ID] ='" + ident + "'");
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            DataT DataT = new DataT();
            
            if (rbSoft.Checked == true)
            {
                reason = "Software crush;";
            }
            if (rbSystem.Checked == true)
            {
                reason += "System crush;";
            }
            reason += textBox1.Text;

            DataTable dt_track = DataT.Select("UPDATE [dbo].[Tracking] SET Reason = '"
                + reason +"', LogOut = '" + DateTime.Now + "'" +
             " WHERE [ID] ='" + ident + "'");

            MessageBox.Show("Reason succesfully updated. Thank you!", "Attention!",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void NoLogOut_Load(object sender, EventArgs e)
        {

        }
    }
}
