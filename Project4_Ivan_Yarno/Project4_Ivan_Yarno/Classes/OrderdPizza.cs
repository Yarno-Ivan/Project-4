using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_Ivan_Yarno.Classes
{
    class OrderdPizza
    {
        private int id;
        private int bestellingid;
        private string pizzanaam;
        private string pizzagrote;
        private string extraopmerking;

        public string PizzaGrote
        {
            get { return pizzagrote; }
            set { pizzagrote = value; }
        }

        public int BestellingID
        {
            get { return bestellingid; }
            set { bestellingid = value; }
        }
        public string PizzaNaam
        {
            get { return pizzanaam; }
            set { pizzanaam = value; }
        }
        public string ExtraOpmerking
        {
            get { return extraopmerking; }
            set { extraopmerking = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
    }
}
