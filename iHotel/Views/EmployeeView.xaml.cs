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
    /// Interaction logic for EmployeeView.xaml
    /// </summary>
    public partial class EmployeeView : Window
    {
        public EmployeeView()
        {
            InitializeComponent();
        }

        public void displayRooms(object sender, RoutedEventArgs e)
        {
            RoomTypes roomTypesWindow = new RoomTypes();
            roomTypesWindow.Show();
        }

        public void displayOffers(object sender, RoutedEventArgs e)
        {
            Offers offersWindow = new Offers();
            offersWindow.Show();
        }

        public void showServices(object sender, RoutedEventArgs e)
        {
            Services servicesWindow = new Services();
            servicesWindow.Show();
        }

        public void showSignUp(object sender, RoutedEventArgs e)
        {
            GuestSignUpWindow signUpWindow = new GuestSignUpWindow();
            signUpWindow.Show();
        }

        public void logIn_Click(object sender, RoutedEventArgs e)
        {
            Login loginWindow = new Login();
            loginWindow.Show();
        }

        public void showReservation(object sender, RoutedEventArgs e)
        {
            EditableReservations editableReservations = new EditableReservations();
            editableReservations.Show();
        }
    }
}
