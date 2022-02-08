using Project4_Ivan_Yarno.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace Project4_Ivan_Yarno
{
    /// <summary>
    /// Interaction logic for NavigatieMenu.xaml
    /// </summary>
    public partial class NavigatieMenu : Window
    {
        private int rolid;

        public NavigatieMenu(int rolid)
        {
            InitializeComponent();
            this.rolid = rolid;
            SendUserToPage();
        }
        private void SendUserToPage()
        {
            BtBestellingen.Visibility = Visibility.Hidden;
            BtBezorging.Visibility = Visibility.Hidden;
            BtBeheerPizzas.Visibility = Visibility.Hidden;
            BtBeheerPersoneel.Visibility = Visibility.Hidden;
            BtBeheerKlant.Visibility = Visibility.Hidden;
            BtBeheerIngredienten.Visibility = Visibility.Hidden;
            switch (rolid)
            {
                case 2:
                    BtBestellingen.Visibility = Visibility.Visible;
                    BtBezorging.Visibility = Visibility.Visible;
                    BtBeheerPizzas.Visibility = Visibility.Hidden;
                    BtBeheerPersoneel.Visibility = Visibility.Hidden;
                    BtBeheerKlant.Visibility = Visibility.Hidden;
                    BtBeheerIngredienten.Visibility = Visibility.Hidden;
                    break;
                case 3:
                    BtBestellingen.Visibility = Visibility.Visible;
                    BtBezorging.Visibility = Visibility.Hidden;
                    BtBeheerPizzas.Visibility = Visibility.Hidden;
                    BtBeheerPersoneel.Visibility = Visibility.Hidden;
                    BtBeheerKlant.Visibility = Visibility.Hidden;
                    BtBeheerIngredienten.Visibility = Visibility.Hidden;
                    break;
                case 4:
                    BtBestellingen.Visibility = Visibility.Hidden;
                    BtBezorging.Visibility = Visibility.Visible;
                    BtBeheerPizzas.Visibility = Visibility.Hidden;
                    BtBeheerPersoneel.Visibility = Visibility.Hidden;
                    BtBeheerKlant.Visibility = Visibility.Hidden;
                    BtBeheerIngredienten.Visibility = Visibility.Hidden;
                    break;
                case 5:
                    BtBestellingen.Visibility = Visibility.Visible;
                    BtBezorging.Visibility = Visibility.Visible;
                    BtBeheerPizzas.Visibility = Visibility.Visible;
                    BtBeheerPersoneel.Visibility = Visibility.Visible;
                    BtBeheerKlant.Visibility = Visibility.Visible;
                    BtBeheerIngredienten.Visibility = Visibility.Visible;
                    break;
                case 999:
                    BtBestellingen.Visibility = Visibility.Visible;
                    BtBezorging.Visibility = Visibility.Visible;
                    BtBeheerPizzas.Visibility = Visibility.Visible;
                    BtBeheerPersoneel.Visibility = Visibility.Visible;
                    BtBeheerKlant.Visibility = Visibility.Visible;
                    BtBeheerIngredienten.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void BtBestellingen_Click(object sender, RoutedEventArgs e)
        {
            Bereiding bereiding = new Bereiding(rolid);
            bereiding.Show();
            this.Close();
        }

        private void BtBezorging_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtBeheerIngredienten_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtBeheerKlant_Click(object sender, RoutedEventArgs e)
        {
            BeheerKlanten win = new BeheerKlanten(rolid);
            win.Show();
            this.Close();
        }

        private void BtBeheerPersoneel_Click(object sender, RoutedEventArgs e)
        {
            BeheerPersoneel win = new BeheerPersoneel(rolid);
            win.Show();
            this.Close();
        }

        private void BtPizzas_Click(object sender, RoutedEventArgs e)
        {
            BeheerPizza win = new BeheerPizza(rolid);
            win.Show();
            this.Close();
        }
    }
}
