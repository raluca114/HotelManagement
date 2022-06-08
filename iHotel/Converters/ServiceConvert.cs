using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using iHotel.Models;
using iHotel.ViewModels;

namespace iHotel.Converters
{
    class ServiceConvert : IMultiValueConverter 
    {
        public object Convert(object[] values, Type targhetType, object parameter, System.Globalization.CultureInfo culture)
        {
           
            Service service=new Service();
            service.service_name= values[0].ToString();
            if (int.TryParse(values[1].ToString(), out int value))
            {
             service.service_price = int.Parse(values[1].ToString());
             }
           
            service.service_price = value;
            return service;
                
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
