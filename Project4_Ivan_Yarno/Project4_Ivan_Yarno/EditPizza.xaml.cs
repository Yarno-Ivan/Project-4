using Project4_Ivan_Yarno.Classes;
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
using System.Windows.Shapes;

namespace Project4_Ivan_Yarno
{
    /// <summary>
    /// Interaction logic for EditPizza.xaml
    /// </summary>
    public partial class EditPizza : Window
    {
        DB db = new DB();
        private int pizzaid;
        private Pizza pizza;

        public Pizza Pizza
        {
            get { return pizza; }
            set { pizza = value; }
        }
        public EditPizza(int pizzaid)
        {
            this.pizzaid = pizzaid;
            InitializeComponent();
            Loadklant();
        }
        public void Loadklant()
        {
            Pizza = db.LoadPizza(pizzaid);
            TbID.Text = Pizza.ID.ToString();
            TbNaam.Text = Pizza.Naam.ToString();
            TbInfo.Text = Pizza.Info.ToString();
            TbPrijs.Text = Pizza.Prijs.ToString();
        }
        private void BtCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtOpslaan_Click(object sender, RoutedEventArgs e)
        {
            

            if (db.UpdatePizza(TbID.Text, TbNaam.Text, TbInfo.Text, TbPrijs.Text))
            {
                MessageBox.Show($"Klant : {Pizza.Naam} aangepast");
            }
            else
            {
                MessageBox.Show($"Aanpassen van {Pizza.Naam} mislukt");
            }
            this.Close();
        }
    }
}
