using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1_Tankaeva
{
    public partial class SchdlsChanges : Form
    {
        public SchdlsChanges()
        {
            InitializeComponent();
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                textBox1.Text = openFileDialog1.FileName;
            int insert = 0;
            int fail = 0;
            try
            {
            using (StreamReader sr = new StreamReader(textBox1.Text))
                {
                    string line;
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        if (line.Split(',')[0] == "ADD")
                        {
                            try
                            {
                                DataT DataT = new DataT();
                                //id аэропортов
                                DataTable dt_from = DataT.Select("SELECT ID FROM [dbo].[Airports] WHERE(IATACode = '" + line.Split(',')[4] + "')");
                                DataTable dt_to = DataT.Select("SELECT ID FROM [dbo].[Airports] WHERE(IATACode = '" + line.Split(',')[5] + "')");
                                //id маршрута
                                DataTable dt_routes = DataT.Select("SELECT ID FROM [dbo].[Routes] WHERE (DepartureAirportID =" +
                                    " '"+ dt_from.Rows[0][0].ToString() + "') AND (ArrivalAirportID = '"+ dt_to.Rows[0][0].ToString() + "')");
                                string conf = "true";
                                if (line.Split(',')[8] != "OK")
                                {
                                    conf = "false";
                                }
                            
                                DataTable dt_schdls = DataT.Select("INSERT INTO [dbo].[Schedules] Values ('" + line.Split(',')[1] +
                                    "','" + line.Split(',')[2] + "','" +line.Split(',')[6] + "','"+ dt_routes.Rows[0][0].ToString() +
                                    "','" + line.Split(',')[7] + "','"+conf+"','" + line.Split(',')[3] + "')");
                                insert++;
                            }
                            catch
                            {
                                fail++; 
                            }
                        }
                        if (line.Split(',')[0] == "EDIT")
                        {
                            try
                            {
                                DataT DataT = new DataT();
                                //id аэропортов
                                DataTable dt_from = DataT.Select("SELECT ID FROM [dbo].[Airports] WHERE(IATACode = '" + line.Split(',')[4] + "')");
                                DataTable dt_to = DataT.Select("SELECT ID FROM [dbo].[Airports] WHERE(IATACode = '" + line.Split(',')[5] + "')");
                                //id маршрута
                                DataTable dt_routes = DataT.Select("SELECT ID FROM [dbo].[Routes] WHERE (DepartureAirportID =" +
                                    " '" + dt_from.Rows[0][0].ToString() + "') AND (ArrivalAirportID = '" + dt_to.Rows[0][0].ToString() + "')");
                                string conf = "true";
                                if (line.Split(',')[8] != "OK")
                                {
                                    conf = "false";
                                }
                         

                                DataTable dt_schdls = DataT.Select("UPDATE [dbo].[Schedules] SET Date = '" + line.Split(',')[1] +
                                    "',Time = '" + line.Split(',')[2] + "', AircraftID ='" + line.Split(',')[6] + "', RouteID ='" + dt_routes.Rows[0][0].ToString() +
                                    "',EconomyPrice ='" + line.Split(',')[7] + "',Confirmed = '" + conf + "', FlightNumber = '" + line.Split(',')[3] + "'" +
                                    " WHERE Date = '"+ line.Split(',')[1] + "' AND FlightNumber = '"+ line.Split(',')[3] + "'");
                                insert++;
                            }
                            catch
                            {
                                fail++;
                            }
                        }
                    }
                    MessageBox.Show("Reading ended", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label2.Text = fail.ToString();
                    label3.Text = insert.ToString();
                }
            }
            catch
            {

            }
            


        }
    }
}
