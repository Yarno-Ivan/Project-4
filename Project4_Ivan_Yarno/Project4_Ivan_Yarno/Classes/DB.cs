using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Project4_Ivan_Yarno.Classes
{
    class DB
    {
        string conn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;

        public Login Inloggen(string naam)
        {
            try
            {
                Login login = new Login();
                DataTable DTinloggen = new DataTable();
                using (MySqlConnection con = new MySqlConnection(conn))
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT * FROM users WHERE name = @naam";
                    cmd.Parameters.AddWithValue("@naam", naam);
                    MySqlDataReader read = cmd.ExecuteReader();
                    DTinloggen.Load(read);

                    foreach (DataRow row in DTinloggen.Rows)
                    {
                        login.ID = Convert.ToInt32(row["id"].ToString());
                        login.Naam = row["name"].ToString();
                        login.Wachtwoord = row["password"].ToString();
                    }
                    return login;
                };
            }
            catch (Exception)
            {
                MessageBox.Show("DataBase : inlog gegevens ophalen mislukt");
                throw;
            }
        }

        public Login GetRoleID(int personid)
        {
            try
            {
                Login login = new Login();
                DataTable DTroleid = new DataTable();
                using (MySqlConnection con = new MySqlConnection(conn))
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT * FROM user_roles WHERE user_id = @personid";
                    cmd.Parameters.AddWithValue("@personid", personid);
                    MySqlDataReader read = cmd.ExecuteReader();
                    DTroleid.Load(read);

                    foreach (DataRow row in DTroleid.Rows)
                    {
                        login.RoleID = Convert.ToInt32(row["role_id"].ToString());
                    }
                    return login;
                };
            }
            catch (Exception)
            {
                MessageBox.Show("DataBase : role id ophalen is mislukt");
                return null;
            }
           
        }
        public ObservableCollection<Order> GetAllOrders()
        {
            try
            {
                ObservableCollection<Order> ocReturn = new ObservableCollection<Order>();
                DataTable dtReturn = new DataTable();
                using (MySqlConnection con = new MySqlConnection(conn))
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "select * from bestellingen";
                    MySqlDataReader Reader = cmd.ExecuteReader();
                    dtReturn.Load(Reader);
                    con.Close();
                }
                foreach (DataRow row in dtReturn.Rows)
                {
                    Order order = new Order();
                    order.ID = Convert.ToInt32(row["ID"]);
                    order.KlantID = row["id-klant"].ToString();
                    order.TotaalPrijs = row["TotaalPrijs"].ToString();
                    order.Status = row["Status"].ToString();
                    ocReturn.Add(order);
                }
                return ocReturn;
            }
            catch (Exception)
            {
                MessageBox.Show("DataBase : orders ophalen mislukt");
                return null;
            }
        }
        public ObservableCollection<OrderdPizza> PizzaLoad(int Idorder)
        {
            try
            {
                ObservableCollection<OrderdPizza> ocReturnpizza = new ObservableCollection<OrderdPizza>();
                DataTable DtPizza = new DataTable();
                using (MySqlConnection con = new MySqlConnection(conn))
                {
                    con.Open();
                    MySqlCommand command = con.CreateCommand();
                    command.CommandText = "SELECT * FROM pizzas INNER JOIN orderd_pizzas ON pizzas.ID = orderd_pizzas.pizza_id AND orderd_pizzas.bestelling_id = @id";


                    command.Parameters.AddWithValue("@Id", Idorder);

                    MySqlDataReader reader = command.ExecuteReader();
                    DtPizza.Load(reader);
                }
                foreach (DataRow row in DtPizza.Rows)
                {
                    OrderdPizza pizza = new OrderdPizza();
                    pizza.ID = Convert.ToInt32(row["id"].ToString());
                    pizza.BestellingID = Convert.ToInt32(row["bestelling_id"].ToString());
                    pizza.PizzaID = Convert.ToInt32(row["pizza_id"].ToString());
                    pizza.PizzaNaam = row["naam"].ToString();
                    ocReturnpizza.Add(pizza);
                }
                return ocReturnpizza;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("DataBase : pizzas inladen mislukt");

                throw;
            }       
        }
        public ObservableCollection<Vooraad> IngredientenLoad(int IdPizza)
        {
            try
            { 
                ObservableCollection<Vooraad> ocReturnvooraad = new ObservableCollection<Vooraad>();
                DataTable Dtvooraad = new DataTable();
                using (MySqlConnection con = new MySqlConnection(conn))
                {
                    con.Open();
                    MySqlCommand command = con.CreateCommand();
                    command.CommandText = "SELECT * FROM vooraad INNER JOIN pizza_vooraad ON vooraad.ID = pizza_vooraad.vooraad_id AND pizza_vooraad.pizza_id = @id";


                    command.Parameters.AddWithValue("@Id", IdPizza);

                    MySqlDataReader reader = command.ExecuteReader();
                    Dtvooraad.Load(reader);
                }
                foreach (DataRow row in Dtvooraad.Rows)
                {
                    Vooraad ingredient = new Vooraad();
                    ingredient.ID = Convert.ToInt32(row["id"].ToString());
                    ingredient.Naam = row["naam"].ToString();
                    ingredient.Aantal = Convert.ToInt32(row["aantal"].ToString());
                    ocReturnvooraad.Add(ingredient);
                }
                return ocReturnvooraad;
            }
            catch (Exception)
            {
                MessageBox.Show("DataBase : pizzas inladen mislukt");
                throw;
            }
        }
        public bool UpdateStatus(string OrderStatus,int Orderid)
        {
            try
            {
                bool succes = false;
                using (MySqlConnection con = new MySqlConnection(conn))
                {
                    con.Open();
                    MySqlCommand command = con.CreateCommand();
                    command.CommandText = "UPDATE `bestellingen` SET `status` = @Status WHERE `bestellingen`.`id` = @orderid;";
                    command.Parameters.AddWithValue("@orderid", Orderid);
                    command.Parameters.AddWithValue("@Status", OrderStatus);
                    int nrOfRowsAffected = command.ExecuteNonQuery();
                    succes = (nrOfRowsAffected != 0);
                }
                return succes;
            }
            catch (Exception)
            {
                MessageBox.Show("DataBase : Status updaten mislukt");
                throw;
            }
           
        }

    }
}
