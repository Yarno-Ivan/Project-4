using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BCrypt.Net;

namespace Project4_Ivan_Yarno
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=opdr5_yarnostevens;Uid=root;Pwd=;sslmode=none");
        MySqlCommand cmd;
        MySqlDataReader dr;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtLogin_Click(object sender, RoutedEventArgs e)
        {
            string user = TbNaam.Text;
            string pass = TbWachtwoord.Text;
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM klantgegevens where naam='" + TbNaam.Text + "' AND wachtwoord='" + BCrypt.Net.BCrypt.Verify(TbWachtwoord.Text, pass) + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Login sucess");
                Registreren registreren = new Registreren();
                registreren.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Fouten inlog gegevens, check uw naam en wachtwoord");
            }
            con.Close();
        }
    }
}
