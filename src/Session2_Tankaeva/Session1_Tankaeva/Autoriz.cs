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
    public partial class Autoriz : Form
    {
        Timer timer1 = new Timer();
        public Autoriz()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        //количество попыток зайти под не существующим пользователем
        int i = 0;
        //таймер
        int t = 10;
        private void Login_Click(object sender, EventArgs e)
        {
            if (log.Text.Length > 0)
            {
                if (pass.Text.Length > 0)
                {
                    //подключение к базе обращаясь к методу из program.cs
                    DataT DataT = new DataT();
                    DataTable dt_user = DataT.Select("SELECT * FROM [dbo].[Users] WHERE [Email] =" +
                        " '" + log.Text + "' AND [Password] = '" + pass.Text + "'");
                    if (dt_user.Rows.Count > 0)
                    {
                       
                        if (dt_user.Rows[0][8].ToString() != "False")
                        {
                            string role = Convert.ToString(dt_user.Rows[0][1]);
                            string email = Convert.ToString(dt_user.Rows[0][2]);

                            //id для трекинга
                            DataTable dt_track = DataT.Select("Select MAX(ID) FROM [dbo].[Tracking]");
                            int idTrack;
                            try
                            {
                                idTrack = Convert.ToInt32(dt_track.Rows[0][0].ToString()) + 1;
                            }
                            catch
                            {
                                idTrack = 1;
                            }
                            //проверка на наличие данных о выходе из системы последний раз
                            DataTable dt_lastID = DataT.Select("Select MAX(ID) FROM [dbo].[Tracking] WHERE UserID = '" + dt_user.Rows[0][0].ToString() + "'");
                            DataTable dt_lastTrack = DataT.Select("Select * FROM [dbo].[Tracking] WHERE ID = '" + dt_lastID.Rows[0][0].ToString() + "'");
                            if (dt_lastTrack.Rows.Count > 0)
                            {
                                string logOut = dt_lastTrack.Rows[0][3].ToString();
                                if (logOut == "")
                                {
                                NoLogOut nlg = new NoLogOut(dt_lastID.Rows[0][0].ToString(), dt_lastTrack.Rows[0][2].ToString());
                                nlg.ShowDialog();
                                }
                            }
                            
                            //запись нового входа
                            DataTable dt_users = DataT.Select("Insert INTO [dbo].[Tracking] VALUES ('" + idTrack + "'," +
                                    "'" + dt_user.Rows[0][0].ToString() + "','" + DateTime.Now + "', null, null)");

                            if (role == "1")
                            {
                                //админ
                                scrAdm adm = new scrAdm(email);
                                adm.ShowDialog();
                            }
                            if (role == "2")
                            {
                                //пользователь
                                scrUser user = new scrUser(email);
                                user.ShowDialog();
                            }
                            if (role == "3")
                            {
                                //менеджер
                                scrMngr mngr = new scrMngr(email);
                                mngr.ShowDialog();
                            }
                        } else MessageBox.Show("Пользователь заблокирован!" ,
                         "Внимание!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    }
                    else
                    {
                        MessageBox.Show("Пользователя не найден", "Ошибка!",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                        i++;
                        if (i == 3)
                        {
                            MessageBox.Show("Вы исчерпали лимит попыток, доступ " +
                        "к программе заблокирован на 10 секунд.", "Внимание!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            login.Enabled = false;
                            timer1.Start();
                        };
                    }
                }
                else MessageBox.Show("Введите пароль", "Внимание!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Введите логин", "Внимание!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
            private void Autoriz_Load(object sender, EventArgs e)
            {
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Interval = 1000;

            }

        private void timer1_Tick(object sender, EventArgs e)
        {
           label3.Text = "Ожидайте: " + (t--).ToString() + " сек.";
           if (t < 0)
           {
                timer1.Stop();
                login.Enabled = true;
                i = 0;
                t = 10;
                label3.Text = "";
           }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
