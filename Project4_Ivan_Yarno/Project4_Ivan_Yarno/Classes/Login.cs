using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_Ivan_Yarno.Classes
{
    class Login
    {
        private int id;
        private string naam;
        private string wachtwoord;

        public string Wachtwoord
        {
            get { return wachtwoord; }
            set { wachtwoord = value; }
        }

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
    }
}
