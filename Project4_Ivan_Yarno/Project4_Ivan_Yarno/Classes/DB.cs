using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_Ivan_Yarno.Classes
{
    class DB
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=opdr5_yarnostevens;Uid=root;Pwd=;sslmode=none");
        MySqlCommand cmd;
        MySqlDataReader dr;
        
    }
}
