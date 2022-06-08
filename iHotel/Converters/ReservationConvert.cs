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
    class ReservationConvert: IMultiValueConverter
    {
        public object Convert(object[] values, Type targhetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Reservation reservation = new Reservation();

            reservation.name = values[0].ToString();
            reservation.phone =values[1].ToString();
            
            reservation.check_in_date = DateTime.Parse(values[2].ToString());
            reservation.check_out_date = DateTime.Parse(values[3].ToString());
            reservation.room_type = values[4].ToString();
            reservation.state = values[5].ToString();

            return reservation;

        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}

