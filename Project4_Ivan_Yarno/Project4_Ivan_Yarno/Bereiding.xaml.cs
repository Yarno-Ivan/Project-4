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
            set { selectedorder = value; OnPropertyChanged(); PizzaLoad(); }
        }

        private OrderdPizza selectedpizza;

        public OrderdPizza SelectedPizza
        {
            get { return selectedpizza; }
            set { selectedpizza = value; OnPropertyChanged(); IngredientenLoad(); }
        }

        private ObservableCollection<Order> bestelling;

        public ObservableCollection<Order> Bestelling
        {
            get { return bestelling; }
            set { bestelling = value; OnPropertyChanged(); }
        }
        private ObservableCollection<OrderdPizza> pizzas;

        public ObservableCollection<OrderdPizza> Pizzas
        {
            get { return pizzas; }
            set { pizzas = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Vooraad> ingredienten;

        public ObservableCollection<Vooraad> Ingredienten
        {
            get { return ingredienten; }
            set { ingredienten = value; OnPropertyChanged(); }
        }
        #endregion
        private int rolid;
        public Bereiding(int rolid)
        {
            this.rolid = rolid;
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
                Pizzas = db.PizzaLoad(SelectedOrder.ID);       
        }
        private void IngredientenLoad()
        {  
                Ingredienten = db.IngredientenLoad(SelectedPizza.ID);
        }

        private void BTPasOrderStatusAan_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)CBStatus.SelectedItem;
            string selectedText = cbi.Content.ToString();
            if (db.UpdateStatus(selectedText, SelectedOrder.ID))
            {
                SelectedOrder.Status = selectedText;
                CBStatus.SelectedValue = "";
                MessageBox.Show($"Status aangepast");
                PizzaLoad();
                LoadAll();
            }
            else
            {
                MessageBox.Show($"Aanpassen van Status mislukt");
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigatieMenu navigatiemenu = new NavigatieMenu(rolid);
            navigatiemenu.Show();
            this.Close();
        }
    }
}
