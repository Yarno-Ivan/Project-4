using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_Ivan_Yarno.Classes
{
    public class Vooraad
    {
        private int id;
        private string naam;
        private int aantal;

        
        public int Aantal
        {
            get { return aantal; }
            set { aantal = value; }
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
