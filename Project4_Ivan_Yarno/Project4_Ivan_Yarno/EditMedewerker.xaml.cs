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
    /// Interaction logic for EditMedewerker.xaml
    /// </summary>
    public partial class EditMedewerker : Window
    {
        private string salt;
        private string hash;
        DB db = new DB();
        private int personeelid;
        int roleid = 1;

        private User personeel;

        public User Personeel
        {
            get { return personeel; }
            set { personeel = value; }
        }
        public EditMedewerker(int personeelid)
        {
            this.personeelid = personeelid;
            InitializeComponent();
            LoadPersoneel();
        }
        public void LoadPersoneel()
        {
            Personeel = db.LoadUser(personeelid);
            TbID.Text = Personeel.ID.ToString();
            TbVoornaam.Text = Personeel.Naam.ToString();
            TbAchternaam.Text = Personeel.AchterNaam.ToString();
            TbEmail.Text = Personeel.Email.ToString();
            TbAdres.Text = Personeel.Adres.ToString();
            TbTelefoon.Text = Personeel.TelefoonNummer.ToString();
            TbPostcode.Text = Personeel.PostCode.ToString();
            TbStad.Text = Personeel.Stad.ToString();
            TbPunten.Text = Personeel.PizzaPunten.ToString();
            switch (Personeel.RoleID)
            {
                case 1:
                    CbRoleID.Text = "Klant";
                    break;
                case 2:
                    CbRoleID.Text = "Balie";
                    break;
                case 3:
                    CbRoleID.Text = "Bereiding";
                    break;
                case 4:
                    CbRoleID.Text = "Bezorging";
                    break;
                case 5:
                    CbRoleID.Text = "Management";
                    break;
                case 999:
                    CbRoleID.Text = "Admin";
                    break;
            }

        }
        private void BtCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtOpslaan_Click(object sender, RoutedEventArgs e)
        {
            salt = BCrypt.Net.BCrypt.GenerateSalt();
            hash = BCrypt.Net.BCrypt.HashPassword(TbWachtwoord.Text, salt);

            if (db.UpdateUser(TbID.Text, TbVoornaam.Text, TbAchternaam.Text, TbEmail.Text, hash, TbAdres.Text, TbTelefoon.Text, TbPostcode.Text, TbStad.Text, TbPunten.Text))
            {
                MessageBox.Show($"Klant : {Personeel.FullName} aangepast");
            }
            else
            {
                MessageBox.Show($"Aanpassen van {Personeel.FullName} mislukt");
            }
            this.Close();
        }
        private void CbRoleID_Change(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)CbRoleID.SelectedItem;
            string selectedText = cbi.Content.ToString();
            switch (selectedText)
            {
                case "Klant":
                    roleid = 1;
                    break;
                case "Balie":
                    roleid = 2;
                    break;
                case "Bereiding":
                    roleid = 3;
                    break;
                case "Bezorging":
                    roleid = 4;
                    break;
                case "Management":
                    roleid = 5;
                    break;
                case "Admin":
                    roleid = 999;
                    break;
            }
            db.SetUserRoleID(Convert.ToInt32(TbID.Text), roleid);

        }
    }
}
