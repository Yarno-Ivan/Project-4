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
        private string klantid;
        private string totaalprijs;
        private string status;
            
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string KlantID
        {
            get { return klantid; }
            set { klantid = value; }
        }
        public string TotaalPrijs
        {
            get { return totaalprijs; }
            set { totaalprijs = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
    }
}
