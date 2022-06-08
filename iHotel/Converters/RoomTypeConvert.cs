using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Data;
using iHotel.Models;

namespace iHotel.Converters
{
    class RoomTypeConvert : IMultiValueConverter
    {
        public object Convert(object[] values, Type targhetType, object parameter, System.Globalization.CultureInfo culture)
        {

            RoomType roomType = new RoomType();
            roomType.type = values[0].ToString();
            roomType.image1 = values[1].ToString();
            roomType.image2 = values[2].ToString();
            if (int.TryParse(values[3].ToString(), out int valueCapacity))
            {
                roomType.capacity = int.Parse(values[3].ToString());
            }
            roomType.capacity = valueCapacity;

            if (int.TryParse(values[4].ToString(), out int valueNrOfRooms))
            {
                roomType.nr_of_rooms = int.Parse(values[4].ToString());
            }
            roomType.nr_of_rooms = valueNrOfRooms;

            if (int.TryParse(values[5].ToString(), out int valuePrice))
            {
                roomType.price_id = int.Parse(values[5].ToString());
            }
            roomType.price_id = valuePrice;

            return roomType;
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
