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
    class PricesConvert: IMultiValueConverter 
    {
        public object Convert(object[] values, Type targhetType, object parameter, System.Globalization.CultureInfo culture)
        {
        Price price= new Price();
        
        if (int.TryParse(values[0].ToString(), out int value))
        {
                price.price1=int.Parse(values[0].ToString());
        }
        price.check_in_date=DateTime.Parse(values[1].ToString());
        price.check_out_date = DateTime.Parse(values[2].ToString());

        return price;

    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
    }
}
