using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_Ivan_Yarno.Classes
{
    class DB
    {
        string conn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;

        public Login Inloggen(string naam, string wachtwoord)
        {
            Login login = new Login();
            DataTable DTinloggen = new DataTable();
            using (MySqlConnection con = new MySqlConnection(conn))
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM users WHERE name = @naam AND Password = @wachtwoord";
                cmd.Parameters.AddWithValue("@naam", naam);
                cmd.Parameters.AddWithValue("@wachtwoord",  wachtwoord);
                MySqlDataReader read = cmd.ExecuteReader();
                DTinloggen.Load(read);
                //BCrypt.Net.BCrypt.Verify(TbWachtwoord.Text, hash);

                foreach (DataRow row in DTinloggen.Rows)
                {
                    login.ID = Convert.ToInt32(row["id"].ToString());
                    login.Naam = row["name"].ToString();
                    login.Wachtwoord = row["password"].ToString();
                }
                return login;
            };
        }
        
    }
}
