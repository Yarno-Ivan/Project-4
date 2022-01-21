﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public Login Inloggen(string naam)
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

        public Login GetRoleID(int personid)
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
        public ObservableCollection<Order> GetAllOrders()
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
        public ObservableCollection<OrderdPizza> PizzaLoad(string Idorder)
        {
            ObservableCollection<OrderdPizza> ocReturnpizza = new ObservableCollection<OrderdPizza>();
            DataTable DtPizza = new DataTable();
            using (MySqlConnection con = new MySqlConnection(conn))
            {
                con.Open();
                MySqlCommand command = con.CreateCommand();
                command.CommandText = "SELECT * FROM orderdpizzas WHERE bestelling_id = @Id";

                command.Parameters.AddWithValue("@Id", Idorder);

                MySqlDataReader reader = command.ExecuteReader();
                DtPizza.Load(reader);
            }
            foreach (DataRow row in DtPizza.Rows)
            {
                OrderdPizza pizza = new OrderdPizza();
                pizza.ID = Convert.ToInt32(row["id"].ToString());
                pizza.BestellingID = Convert.ToInt32(row["bestelling_id"].ToString());
                pizza.PizzaNaam = row["naam"].ToString();
                pizza.PizzaGrote = row["grote"].ToString();
                pizza.ExtraOpmerking = row["extra-opmerking"].ToString();
                ocReturnpizza.Add(pizza);
            }
            return ocReturnpizza;
        }
        public bool UpdateStatus(string OrderStatus,int Orderid)
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

    }
}
