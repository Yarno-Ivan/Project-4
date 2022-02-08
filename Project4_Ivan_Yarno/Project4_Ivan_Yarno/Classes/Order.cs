using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_Ivan_Yarno.Classes
{
    public class Order
    {
        private int id;
        private string naam;
        private string adres;
        private string email;
        private string status;
            
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }
        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
    }
}
