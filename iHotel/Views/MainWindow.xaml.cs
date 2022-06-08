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
using System.Windows.Navigation;
using System.Windows.Shapes;
using iHotel.Views;


namespace iHotel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void showServices(object sender, RoutedEventArgs e)
        {
            EditableServices editableServices = new EditableServices();
            editableServices.Show();
        }

        public void displayRooms(object sender, RoutedEventArgs e)
        {
            EditableRoomTypes editableRoomTypes = new EditableRoomTypes();
            editableRoomTypes.Show();
        }

        public void displayOffers(object sender, RoutedEventArgs e)
        {
            EditableOffers editableOffersWindow = new EditableOffers();
            editableOffersWindow.Show();
        }

        public void showFacilities(object sender, RoutedEventArgs e)
        {
            Facilities facilitiesWindow = new Facilities();
            facilitiesWindow.Show();
        }

        public void displayPrices(object sender, RoutedEventArgs e)
        {
            EditablePrices editablePricesWindow = new EditablePrices();
            editablePricesWindow.Show();
        }

        public void showReservations(object sender, RoutedEventArgs e)
        {
            EditableReservations reservationsWindow = new EditableReservations();
            reservationsWindow.Show();
        }
    }
}
