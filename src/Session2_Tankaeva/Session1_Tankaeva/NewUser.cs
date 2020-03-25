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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "session2_TankaevaDataSet.Offices". При необходимости она может быть перемещена или удалена.
            this.officesTableAdapter.Fill(this.session2_TankaevaDataSet.Offices);

        }


        private void AddUser_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" &&
          textBox4.Text != "" && comboBox1.SelectedIndex != -1 && textBox6.Text != "")
            {

                DataT DataT = new DataT();
                DataTable dt_u = DataT.Select("Select MAX(ID) FROM [dbo].[Users]");
                //генерируем id - находим последний номер + 1
                int idU = Convert.ToInt32(dt_u.Rows[0][0].ToString()) + 1;
                //индекс офиса - индекс элемента из выпадающего списка + 1
                int of = comboBox1.SelectedIndex + 1;
                try
                {
                    DataTable dt_users = DataT.Select("Insert INTO [dbo].[Users] VALUES('" + idU + "','2', '" + textBox1.Text + "','" +
                    textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + of + "','" + Convert.ToDateTime(textBox6.Text) + "', 'True')");
                    MessageBox.Show("Сотрудник успешно добавлен", "Внимание!",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Заполните все поля коректно!", "Внимание!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Внимание!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
