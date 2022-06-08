using System;
using System.Collections.Generic;
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

namespace iHotel.Views
{
    /// <summary>
    /// Interaction logic for RoomTypes.xaml
    /// </summary>
    public partial class RoomTypes : Window
    {
        public RoomTypes()
        {
            InitializeComponent();
        }
        public void btnShowRoomFacilities_Click(object sender, RoutedEventArgs e)
        {
            //Facilities facilitiesWindow = new Facilities();
            //facilitiesWindow.ShowDialog();

            //EditableFacilities facilitiesWindow = new EditableFacilities();
            //facilitiesWindow.ShowDialog();

            GuestFacilities guestFacilitiesWindow = new GuestFacilities();
            guestFacilitiesWindow.Show();
        }
        
    }
}
