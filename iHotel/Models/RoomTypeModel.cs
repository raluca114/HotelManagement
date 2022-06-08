using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iHotel.Models
{
    public class RoomTypeModel
    {
        private HotelEntities context = new HotelEntities();

        public ObservableCollection<RoomType> RoomTypeList { get; set; }

        public string ErrorMessage { get; set; }

        public void AddMethod(object obj)
        {
            RoomType roomType = obj as RoomType;
            roomType.deleted = false;
            if (roomType != null)
            {
                if (string.IsNullOrEmpty(roomType.type))
                {
                    ErrorMessage = "Please insert the room type.";
                }
                else
                {
                    context.AddRoomType(roomType.type, roomType.image1, roomType.image2, roomType.capacity, roomType.nr_of_rooms, roomType.price_id, roomType.deleted);
                    context.SaveChanges();
                    RoomTypeList.Add(roomType);
                    ErrorMessage = "";
                }
            }
        }

        public void UpdateMethod(object obj)
        {
            RoomType rT=obj as RoomType;
            if(rT == null)
            {
                ErrorMessage = "Select a room!";
            }
            else if(string.IsNullOrEmpty(rT.type))
            {
                ErrorMessage = "Insert the room type label";
            }
            else
            {
                context.UpdateRoom(rT.type,rT.type,rT.image1,rT.image2,rT.capacity, rT.nr_of_rooms,rT.price_id, rT.deleted);
                context.SaveChanges();
                ErrorMessage = "";
            }
        }

        public void DeleteMethod(object obj)
        {
            RoomType rT=obj as RoomType;
            if(rT==null)
            {
                ErrorMessage = "Select a room!";
            }
            else 
            {
                context.DeleteRoomType(rT.type);
                context.SaveChanges();
                RoomTypeList.Remove(rT);
                ErrorMessage = "";
            }
        }

        public ObservableCollection<RoomType> GetAllRoomTypes()
        {
            List<RoomType> roomTypes = context.RoomTypes.ToList();
            ObservableCollection<RoomType> result = new ObservableCollection<RoomType>();
            foreach (RoomType roomType in roomTypes)
            {
                if (roomType.deleted == false)
                {
                    result.Add(roomType);
                }
            }
            return result;
        }
    }
}
