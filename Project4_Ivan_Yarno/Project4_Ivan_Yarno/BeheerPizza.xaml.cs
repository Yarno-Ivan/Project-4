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
    /// Interaction logic for BeheerPizza.xaml
    /// </summary>
    public partial class BeheerPizza : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        DB db = new DB();
        private ObservableCollection<Pizza> pizza;

        public ObservableCollection<Pizza> Pizza
        {
            get { return pizza; }
            set { pizza = value; OnPropertyChanged(); }
        }
        private Pizza selectedpizza;

        public Pizza SelectedPizza
        {
            get { return selectedpizza; }
            set { selectedpizza = value; OnPropertyChanged(); }
        }
        private int rolid;
        public BeheerPizza(int rolid)
        {
            this.rolid = rolid;
            DataContext = this;
            InitializeComponent();
            LoadPizza();
        }

        private void LoadPizza()
        {
            Pizza = db.GetAllPizza();
        }
        private void Del_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageBox.Show($"Weet u zeker dat u de pizza {SelectedPizza.Naam} wilt verwijderen?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                {
                    //do no stuff
                }
                else
                {
                    db.DeletePizza(SelectedPizza.ID);
                    MessageBox.Show($"{SelectedPizza.Naam} is verwijderd");
                    LoadPizza();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("selecteer eerst een Pizza voordat u op verwijderen klikt");
            }
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EditPizza edit = new EditPizza(SelectedPizza.ID);
                edit.ShowDialog();
                LoadPizza();
            }
            catch (Exception)
            {
                MessageBox.Show("selecteer eerst een Pizza voordat u op edit klikt");
            }
        }

        private void MaakAan_Click(object sender, RoutedEventArgs e)
        {
            CreatePizza create = new CreatePizza();
            create.ShowDialog();
            LoadPizza();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigatieMenu navigatiemenu = new NavigatieMenu(rolid);
            navigatiemenu.Show();
            this.Close();
        }
    }
}
