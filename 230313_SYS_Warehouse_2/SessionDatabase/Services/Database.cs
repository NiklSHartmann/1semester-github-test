using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionDatabase.Services
{
    internal class Database
    {
        // Conntects to the database 
        static string strconn = "Data Source=mssql9.unoeuro.com;Initial Catalog=hart_ware_dk_db_database;User ID=hart_ware_dk;Password=4trbxkBanhmRFdGgc5A3";

        public static void CreateDummyData()
        {
            SqlConnection conn = new SqlConnection(strconn);

            string sSQL = $"CREATE TABLE Session (\r\n    SessionDato DATETIME,\r\n    SessionStatus VARCHAR(20),\r\n    SessionVarighed TIME,\r\n    SessionId INT\r\n\r\n   ....\r\n);";

        }

        public static void FindActiveSessions()
        {
            SqlConnection conn = new SqlConnection(strconn);

            string sSQL = $"SELECT * FROM Session WHERE SessionStatus = 'Active';";
           
            SqlCommand command = new SqlCommand(sSQL, conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                //Column headers with tab [\t] spaces between them
                Console.WriteLine("{0}\t{1}\t\t{2}\t{3}\t{4}",
            reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4));
            }
            conn.Close();

        }


    }
}

