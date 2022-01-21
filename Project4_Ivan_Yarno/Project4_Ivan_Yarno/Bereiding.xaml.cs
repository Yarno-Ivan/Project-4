using Project4_Ivan_Yarno.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    public partial class Bereiding : Window, INotifyPropertyChanged
    {
        #region links
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        DB db = new DB();
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private Order selectedorder;

        public Order SelectedOrder
        {
            get { return selectedorder; }
            set { selectedorder = value; }
        }
        private ObservableCollection<Order> bestelling;

        public ObservableCollection<Order> Bestelling
        {
            get { return bestelling; }
            set { bestelling = value; OnPropertyChanged(); }
        }
        #endregion
        public Bereiding()
        {
            InitializeComponent();
            DataContext = this;
            LoadAll();
        }
        private void LoadAll()
        {
            Bestelling = db.GetAllOrders();
        }

        private void PizzaLoad()
        {
            try
            {
                Order order = (Order)LvOrders.SelectedItem;
                Id = order.ID.ToString();
                LvPizzas.ItemsSource = db.PizzaLoad(Id).ToList();
                TbStatus.Text = order.Status;
            }
            catch (Exception) { }
        }


        private void SCorders(object sender, SelectionChangedEventArgs e)
        {
            PizzaLoad();

        }

        private void BTPasOrderStatusAan_Click(object sender, RoutedEventArgs e)
        {
            Order order = (Order)LvOrders.SelectedItem;
            ComboBoxItem cbi = (ComboBoxItem)CBStatus.SelectedItem;
            string selectedText = cbi.Content.ToString();
            if (db.UpdateStatus(selectedText, order.ID))
            {
                PizzaLoad();
                order.Status = selectedText;
                TbStatus.Text = order.Status;
                CBStatus.SelectedValue = "";
                MessageBox.Show($"Status aangepast");
            }
            else
            {
                MessageBox.Show($"Aanpassen van Status mislukt");
            }
        }
    }
}
