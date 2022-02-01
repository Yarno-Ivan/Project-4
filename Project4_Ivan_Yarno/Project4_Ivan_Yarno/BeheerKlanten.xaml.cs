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
    /// Interaction logic for BeheerKlanten.xaml
    /// </summary>
    public partial class BeheerKlanten : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        DB db = new DB(); 
        private ObservableCollection<User> klanten;

        public ObservableCollection<User> Klanten
        {
            get { return klanten; }
            set { klanten = value; OnPropertyChanged(); }
        }
        private User selectedklant;

        public User SelectedKlant
        {
            get { return selectedklant; }
            set { selectedklant = value; OnPropertyChanged(); }
        }
        public BeheerKlanten()
        {
            DataContext = this;
            InitializeComponent();
            LoadKlanten();
        }

        private void LoadKlanten()
        {
            Klanten = db.GetAllKlanten();
        }
        private void Del_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageBox.Show($"Weet u zeker dat u {SelectedKlant.FullName} wilt verwijderen?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                {
                    //do no stuff
                }
                else
                {
                    db.DeleteUser(SelectedKlant.ID);
                    MessageBox.Show($"{SelectedKlant.FullName} is verwijderd");
                    LoadKlanten();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("selecteer eerst een klant voordat u op verwijderen klikt");
            }
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EditKlanten edit = new EditKlanten(SelectedKlant.ID);
                edit.ShowDialog();
                LoadKlanten();
            }
            catch (Exception)
            {
                MessageBox.Show("selecteer eerst een klant voordat u op edit klikt");
            }
            
        }
    }

}
