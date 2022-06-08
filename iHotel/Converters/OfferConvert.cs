using System;
using System.Collections.Generic;
using System.Windows.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iHotel.Models;
using System.Globalization;

namespace iHotel.Converters
{
    class OfferConvert : IMultiValueConverter
    {
        public object Convert(object[] values, Type targhetType, object parameter, System.Globalization.CultureInfo culture)
        {

            Offer offer = new Offer();
            offer.offer_name = values[0].ToString();
            offer.offer_description = values[1].ToString();

            if (int.TryParse(values[2].ToString(), out int valueRT))
            {
                offer.room_type_id = int.Parse(values[2].ToString());
            }

            offer.room_type_id = valueRT;

            if (int.TryParse(values[3].ToString(), out int valueP))
            {
                offer.price_id = int.Parse(values[3].ToString());
            }

            offer.room_type_id = valueP;
            return offer;

        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    }
