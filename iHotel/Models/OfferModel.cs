using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iHotel.Models
{
    public class OfferModel
    {
        private HotelEntities context=new HotelEntities();

        public ObservableCollection<Offer> OffersList { get; set; }

        public string ErrorMessage { get; set; }

        public void AddMethod(object obj)
        {
            Offer offer = obj as Offer;
            offer.deleted = false;
            if (offer != null)
            {
                if(string.IsNullOrEmpty(offer.offer_name))
                {
                    ErrorMessage = "Please insert a name for the offer!";
                }
                else
                {
                    context.Offers.Add(new Offer() { offer_name = offer.offer_name, offer_description=offer.offer_description,room_type_id=offer.room_type_id, price_id=offer.price_id, deleted=offer.deleted });
                    context.SaveChanges();
                    OffersList.Add(offer);
                    ErrorMessage = "";
                }
            }
        }

        public void UpdateMethod(object obj)
        {
            Offer offer=obj as Offer;
            offer.deleted=false;
            if(offer==null)
            {
                ErrorMessage = "Select an offer!";
            }
            else if(string.IsNullOrEmpty(offer.offer_name))
            {
                ErrorMessage = "Insert the offer label!";
            }
            else
            {
                context.UpdateOffer(offer.offer_name, offer.offer_name, offer.offer_description, offer.room_type_id, offer.price_id);
                context.SaveChanges();
                ErrorMessage = "";
            }
        }

        public void DeleteMethod(object obj)
        {
            Offer offer= obj as Offer;
            if(offer==null)
            {
                ErrorMessage = "Select an offer!";
            }
            else
            {
                context.DeleteOffer(offer.offer_name);
                context.SaveChanges();
                OffersList.Remove(offer);
                ErrorMessage = "";
            }
        }

        public ObservableCollection<Offer> GetAllOffers()
        {
            List<Offer> offers = context.Offers.ToList();
            ObservableCollection<Offer> result = new ObservableCollection<Offer>();
            foreach(Offer offer in offers)
            {
                if(offer.deleted==false)
                {
                    result.Add(offer);
                }
            }
            return result;
        }
    }
}
