using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project4_Ivan_Yarno.Classes
{
    public class User : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        private int id;
        private string naam;
        private string achternaam;
        private string email;
        private string adres;
        private string telefoonnummer;
        private string postcode;
        private string stad;
        private int pizzapunten;
        private string password;
        private int roleid;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public int RoleID
        {
            get { return roleid; }
            set { roleid = value; }
        }
        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }
        public string PassWord
        {
            get { return password; }
            set { password = value; }
        }
        public string AchterNaam
        {
            get { return achternaam; }
            set { achternaam = value; }
        }
        public string FullName
        {
            get { return naam + " " + achternaam; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }
        public string TelefoonNummer
        {
            get { return telefoonnummer; }
            set { telefoonnummer = value; }
        }
        public string PostCode
        {
            get { return postcode; }
            set { postcode = value; }
        }
        public string Stad
        {
            get { return stad; }
            set { stad = value; }
        }
        public int PizzaPunten
        {
            get { return pizzapunten; }
            set { pizzapunten = value; }
        }

    }
}
