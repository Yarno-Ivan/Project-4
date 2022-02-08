using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_Ivan_Yarno.Classes
{
    public class Pizza
    {
        private int id;
        private string naam;
        private string info;
        private double prijs;

        public string Info
        {
            get { return info; }
            set { info = value; }
        }
        public double Prijs
        {
            get { return prijs; }
            set { prijs = value; }
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
