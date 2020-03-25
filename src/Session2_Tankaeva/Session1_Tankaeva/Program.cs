using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1_Tankaeva
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Autoriz());
            //Application.Run(new scrAdm("j.doe@amonic.com"));
            //Application.Run(new scrUser("k.omar@amonic.com"));
            //Application.Run(new scrMngr("m@.com"));
            //Application.Run(new SchdlsChanges());
        }
    }
    public class DataT
    {
        public DataTable Select(string selectSQL)
        {
            DataTable dataTable = new DataTable("dataBase");
            //1 сессия 
            //SqlConnection sqlConnection = new SqlConnection("server=LAPTOP-HIOJQFOH;" +
            //    "Trusted_Connection=Yes;DataBase=Session1_Tankaeva;Max Pool Size=10000;");
            SqlConnection sqlConnection = new SqlConnection("server=LAPTOP-HIOJQFOH;" +
               "Trusted_Connection=Yes;DataBase=Session2_Tankaeva;Max Pool Size=10000;");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = selectSQL;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}
