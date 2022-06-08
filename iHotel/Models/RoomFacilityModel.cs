using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iHotel.Models
{
    public class RoomFacilityModel
    {
        private HotelEntities context = new HotelEntities();
        public ObservableCollection<Facility> FacilitiesList { get; set; }

        public string ErrorMessage { get; set; }

        public void AddMethod(object obj)
        {
            Facility fac = obj as Facility;
            fac.deleted = false;
            if (fac != null)
            {
                if (string.IsNullOrEmpty(fac.facility1))
                {
                    ErrorMessage = "Please insert a name";
                }
                else
                {
                    context.AddNewFacility(fac.facility1, fac.deleted);
                    context.SaveChanges();
                    FacilitiesList.Add(fac);
                    ErrorMessage = "";
                }
            }
        }

        public void UpdateMethod(object obj)
        {
            Facility fac =obj as Facility;
            if(fac==null)
            {
                ErrorMessage = "Select a facility";
            }
            else if(string.IsNullOrEmpty(fac.facility1))
            {
                ErrorMessage = "Insert the facility label.";
            }
            else
            {
                context.UpdateFacility(fac.facility1, fac.facility1);
                context.SaveChanges();
                ErrorMessage = "";
            }
        }

        public void DeleteMethod(object obj)
        {
            Facility fac=obj as Facility;
            if(fac==null)
            {
                ErrorMessage = "Select a facility";
            }
            else
            {
                context.DeleteFacility(fac.facility1);
                context.SaveChanges();
                FacilitiesList.Remove(fac);
                ErrorMessage = "";
            }
        }

        public ObservableCollection<Facility> GetAllFacilities()
        {
            List<Facility> facilities = context.Facilities.ToList();
            ObservableCollection<Facility> result = new ObservableCollection<Facility>();
            foreach (Facility facility in facilities)
            {
                if (facility.deleted == false)
                {
                    result.Add(facility);
                }
            }
            return result;
        }
    }
}
