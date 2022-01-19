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
using Project4_Ivan_Yarno.Classes;

namespace Project4_Ivan_Yarno
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DB Conn = new DB();
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }
        private void BtLogin_Click(object sender, RoutedEventArgs e)
        {
            Login login = Conn.Inloggen(TbNaam.Text);
            MessageBox.Show(login.ID.ToString(), login.Naam);
            bool PassBcrypt = BCrypt.Net.BCrypt.Verify(TbWachtwoord.Text, login.Wachtwoord);
            if (PassBcrypt == true)
            {
                Login loginroleid = Conn.GetRoleID(login.ID);
                switch (loginroleid.RoleID)
                {
                    case 2:
                        Balie balie = new Balie();
                        balie.Show();
                        this.Close();
                        break;
                    case 3:
                        Bereiding bereiding = new Bereiding();
                        bereiding.Show();
                        this.Close();
                        break;
                    case 4:
                        Bezorging bezorging = new Bezorging();
                        bezorging.Show();
                        this.Close();
                        break;
                    case 5:
                        management management = new management();
                        management.Show();
                        this.Close();
                        break;
                    case 6:
                        Admin admin = new Admin();
                        admin.Show();
                        this.Close();
                        break;
                }
            }
            else
            {
                MessageBox.Show("wachtwoord of naam onjuist probeer opnieuw");
            }
        }
    }
}
