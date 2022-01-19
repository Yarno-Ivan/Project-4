using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_Ivan_Yarno.Classes
{
    public class Login
    {
        private int roleid;
        private int id;
        private string naam;
        private string wachtwoord;

        public int RoleID
        {
            get { return roleid; }
            set { roleid = value; }
        }
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
