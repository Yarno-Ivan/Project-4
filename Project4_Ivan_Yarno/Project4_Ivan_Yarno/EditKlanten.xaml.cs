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
    /// Interaction logic for EditKlanten.xaml
    /// </summary>
    public partial class EditKlanten : Window
    {
        private string salt;
        private string hash;
        DB db = new DB();
        private int klantid;
        int roleid = 1;
        private User klant;

        public User Klant
        {
            get { return klant; }
            set { klant = value; }
        }
        public EditKlanten(int klantid)
        {
            this.klantid = klantid;
            InitializeComponent();
            Loadklant();
        }
        public void Loadklant()
        {
            Klant = db.LoadUser(klantid);
            TbID.Text = Klant.ID.ToString();
            TbVoornaam.Text = Klant.Naam.ToString();
            TbAchternaam.Text = Klant.AchterNaam.ToString();
            TbEmail.Text = Klant.Email.ToString();
            TbAdres.Text = Klant.Adres.ToString();
            TbTelefoon.Text = Klant.TelefoonNummer.ToString();
            TbPostcode.Text = Klant.PostCode.ToString();
            TbStad.Text = Klant.Stad.ToString();
            TbPunten.Text = Klant.PizzaPunten.ToString();
            switch (Klant.RoleID)
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
                MessageBox.Show($"Klant : {Klant.FullName} aangepast");
            }
            else
            {
                MessageBox.Show($"Aanpassen van {Klant.FullName} mislukt");
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
