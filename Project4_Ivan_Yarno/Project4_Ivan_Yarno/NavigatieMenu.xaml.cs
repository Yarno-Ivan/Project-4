using Project4_Ivan_Yarno.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for NavigatieMenu.xaml
    /// </summary>
    public partial class NavigatieMenu : Window
    {
        
        private DB Conn = new DB();
        private int rolid;

        public NavigatieMenu(int rolid)
        {
            InitializeComponent();
            this.rolid = rolid;
            SendUserToPage();
        }
        private void SendUserToPage()
        {
            switch (rolid)
            {
                case 2:
                    Balie balie = new Balie();
                    balie.Show();
                    this.Close();
                    break;
                case 3:
                    Bereiding bereiding = new Bereiding();
                    bereiding.Show();
                    this.Close();
                    break;
                case 4:
                    Bezorging bezorging = new Bezorging();
                    bezorging.Show();
                    this.Close();
                    break;
                case 5:
                    management management = new management();
                    management.Show();
                    this.Close();
                    break;
                case 6:
                    Admin admin = new Admin();
                    admin.Show();
                    this.Close();
                    break;
                default:
                    MessageBox.Show("U heeft geen toegang tot dit systeem");
                    break;
            }
        }
    }
}
