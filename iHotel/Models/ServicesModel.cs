using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iHotel.Models
{
    public class ServicesModel
    {
        private HotelEntities context=new HotelEntities();

        public ObservableCollection<Service> ServicesList { get; set; }

        public string ErrorMessage { get; set; }

        public void AddMethod(object obj)
        {
            Service service=obj as Service;
            if(service!=null)
            {
                if(string.IsNullOrEmpty(service.service_name))
                {
                    ErrorMessage = "Please give this service a name.";
                }
                else
                {
                    context.AddService(service.service_name, service.service_price.ToString());
                    context.SaveChanges();
                    ServicesList.Add(service);
                    ErrorMessage = "";
                }
            }
        }

        public void UpdateMethod(object obj)
        {
            Service ser=obj as Service;
            if(ser==null)
            {
                ErrorMessage = "Select a service!";
            }
            else if(string.IsNullOrEmpty(ser.service_name))
            {
                ErrorMessage = "Insert the a label for service!";
            }
            else
            {
                context.UpdateService(ser.service_name, ser.service_name, ser.service_price);
                context.SaveChanges();
                ErrorMessage = "";
            }
        }

        public void DeleteMethod(object obj)
        {
            Service ser = obj as Service;
            if(ser==null)
            {
                ErrorMessage = "Select a service!";
            }
            else
            {
                context.DeleteService(ser.service_name);
                context.SaveChanges();
                ServicesList.Remove(ser);
                ErrorMessage = "";
            }
        }
        public ObservableCollection<Service> GetAllServices()
        {
            List<Service> services = context.Services.ToList();
            ObservableCollection<Service> result=new ObservableCollection<Service>();
            foreach(Service service in services)
            {
                if (service.deleted == false)
                {
                    result.Add(service);
                }
            }
            return result;
        }

    }
}
