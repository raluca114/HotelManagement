using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iHotel.Models
{
    public class PriceModel
    {
        private HotelEntities context=new HotelEntities();

        public ObservableCollection<Price> PricesList { get; set; }

        public string ErrorMessage { get; set; }

        public void AddMethod(object obj)
        {
            Price price = obj as Price;
            price.deleted = false;
            if(price!= null)
            {
                if(string.IsNullOrEmpty(price.price1.ToString()))
                {
                    ErrorMessage = "Please insert a price!";
                }
                else
                {
                    context.AddNewPrice(price.price1, price.check_in_date, price.check_out_date, price.deleted);
                    context.SaveChanges();
                    PricesList.Add(price);
                    ErrorMessage = "";
                }
            }
        }

        public void DeleteMethod(object obj)
        {
            Price price=obj as Price;
            if(price==null)
            {
                ErrorMessage = "Select a price!";
            }
            else
            {
                context.DeletePrice((int)price.price1);
            }
        }

        public ObservableCollection<Price> GetAllPrices()
        {
            List<Price> prices=context.Prices.ToList();
            ObservableCollection<Price> result = new ObservableCollection<Price>();
            foreach(Price price in prices)
            {
                if(price.deleted==false)
                {
                    result.Add(price);
                }
            }
            return result;
        }
    }
}
