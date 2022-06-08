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
using iHotel.Models;
using iHotel.ViewModels;

namespace iHotel.Views
{
    /// <summary>
    /// Interaction logic for AddService.xaml
    /// </summary>
    public partial class AddService : Window
    {
        public AddService()
        {
            InitializeComponent();
        }

        public void btnServiceNameCheck(object sender, RoutedEventArgs e)
        {
            serviceLabel.Content = txtServiceName.Text;
            txtServiceName.Text = txtServiceName.Text;
        }

        public void btnServicePriceCheck(object sender, RoutedEventArgs e)
        {
            serviceLabelPrice.Content = txtServicePrice.Text;
            txtServicePrice.Text = txtServicePrice.Text;
        }


    }
}
