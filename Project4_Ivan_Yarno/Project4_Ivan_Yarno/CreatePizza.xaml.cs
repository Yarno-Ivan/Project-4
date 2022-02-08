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
    /// Interaction logic for CreatePizza.xaml
    /// </summary>
    public partial class CreatePizza : Window
    {
        DB db = new DB();
        private int klantid;
        int roleid = 1;
        private Pizza pizza;

        public Pizza Pizza
        {
            get { return pizza; }
            set { pizza = value; }
        }
        public CreatePizza()
        {
            InitializeComponent();
        }

        private void BtCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtOpslaan_Click(object sender, RoutedEventArgs e)
        {
            if (db.InsertPizza(TbNaam.Text, TbInfo.Text, TbPrijs.Text))
            {
                MessageBox.Show($"de pizza : {TbNaam.Text} is aangemaakt");

            }
            else
            {
                MessageBox.Show($"aanmaken mislukt");
            }
            this.Close();

        }
    }
}
