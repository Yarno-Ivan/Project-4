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
    /// Interaction logic for Bereiding.xaml
    /// </summary>
    public partial class Bereiding : Window
    {
        DB db = new DB();
        private ObservableCollection<Order> bestelling;

        public ObservableCollection<Order> Bestelling
        {
            get { return bestelling; }
            set { bestelling = value; }
        }
        public Bereiding()
        {
            InitializeComponent();
            DataContext = this;
            LoadAll();
        }
        private void LoadAll()
        {
            LvOrders.ItemsSource = Bestelling = db.GetAllOrders();
        }
    }
}
