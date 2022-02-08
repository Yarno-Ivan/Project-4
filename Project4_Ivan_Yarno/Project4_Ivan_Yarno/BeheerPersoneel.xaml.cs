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
    /// Interaction logic for BeheerPersoneel.xaml
    /// </summary>
    public partial class BeheerPersoneel : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        DB db = new DB();
        private ObservableCollection<User> personeel;

        public ObservableCollection<User> Personeel
        {
            get { return personeel; }
            set { personeel = value; OnPropertyChanged(); }
        }
        private User selectedmedewerker;

        public User SelectedMedewerker
        {
            get { return selectedmedewerker; }
            set { selectedmedewerker = value; OnPropertyChanged(); }
        }
        private int rolid;
        public BeheerPersoneel(int rolid)
        {
            this.rolid = rolid;
            DataContext = this;
            InitializeComponent();
            LoadPersoneel();
        }

        private void LoadPersoneel()
        {
            Personeel = db.GetAllMedewerkers();
        }
        private void Del_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageBox.Show($"Weet u zeker dat u {SelectedMedewerker.FullName} wilt verwijderen?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                {
                    //do no stuff
                }
                else
                {
                    db.DeleteUser(SelectedMedewerker.ID);
                    MessageBox.Show($"{SelectedMedewerker.FullName} is verwijderd");
                    LoadPersoneel();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("selecteer eerst een Medewerker voordat u op verwijderen klikt");
            }
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EditMedewerker edit = new EditMedewerker(SelectedMedewerker.ID);
                edit.ShowDialog();
                LoadPersoneel();
            }
            catch (Exception)
            {
                MessageBox.Show("selecteer eerst een Medewerker voordat u op edit klikt");
            }
        }

        private void MaakAan_Click(object sender, RoutedEventArgs e)
        {
            CreateMedewerker create = new CreateMedewerker();
            create.ShowDialog();
            LoadPersoneel();

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigatieMenu navigatiemenu = new NavigatieMenu(rolid);
            navigatiemenu.Show();
            this.Close();
        }
    }
}
