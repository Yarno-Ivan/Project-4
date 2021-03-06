using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project4_Ivan_Yarno.Classes
{
    public class OrderdPizza : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        private int id;
        private int bestellingid;
        private int pizzaid;
        private string pizzanaam;

        public int BestellingID
        {
            get { return bestellingid; }
            set { bestellingid = value; }
        }
        public int PizzaID
        {
            get { return pizzaid; }
            set { pizzaid = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string PizzaNaam
        {
            get { return pizzanaam; }
            set { pizzanaam = value; }
        }


    }
}
