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
    /// Interaction logic for CreateMedewerker.xaml
    /// </summary>
    public partial class CreateMedewerker : Window
    {
        private string salt;
        private string hash;
        DB db = new DB();
        private int klantid;
        int roleid = 1;
        private User personeel;

        public User Personeel
        {
            get { return personeel; }
            set { personeel = value; }
        }
        public CreateMedewerker()
        {
            InitializeComponent();
        }
        
        private void BtCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtOpslaan_Click(object sender, RoutedEventArgs e)
        {
            salt = BCrypt.Net.BCrypt.GenerateSalt();
            hash = BCrypt.Net.BCrypt.HashPassword(TbWachtwoord.Text, salt);
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
            if (db.InsertUser(TbVoornaam.Text, TbAchternaam.Text, TbEmail.Text, hash, TbAdres.Text, TbTelefoon.Text, TbPostcode.Text, TbStad.Text, TbPunten.Text))
            {
                db.GetUserByMail(TbEmail.Text);
                db.SetUserRoleID(Convert.ToInt32(Personeel.ID), roleid);
                MessageBox.Show($"Medewerker : {TbVoornaam} is aangemaakt");
            }
            else
            {
                MessageBox.Show($"aanmaken misluktS");
            }
            this.Close();

        }
    }
}
