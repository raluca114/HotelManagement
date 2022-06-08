using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using iHotel.Helpers;
using iHotel.Models;

namespace iHotel.ViewModels
{
    public class OffersViewModel: BaseVM
    {
        private OfferModel offers;

        public OffersViewModel()
        {
            offers = new OfferModel();
            offersList = offers.GetAllOffers();
        }

        #region Data Members

        public ObservableCollection<Offer> offersList
        {
            get => offers.OffersList;
            set=> offers.OffersList = value;
        }

        private string errorMessage;

        public string ErrorMessage
        {
            get => errorMessage;
            set
            {
                errorMessage = value;
                NotifyPropertyChanged("ErrorMessage");
            }
        }
        #endregion

        #region Command Members
        public void AddMethod(object obj)
        {
            offers.AddMethod(obj);
            ErrorMessage = offers.ErrorMessage;
        }
        private ICommand addCommand;

        public ICommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new RelayCommand(AddMethod);
                }
                return addCommand;
            }
        }

        public void UpdateMethod(object obj)
        {
            offers.UpdateMethod(obj);
            ErrorMessage = offers.ErrorMessage;
        }

        private ICommand updateCommand;

        public ICommand UpdateCommand
        {
            get
            {
                if (updateCommand == null)
                {
                    updateCommand = new RelayCommand(UpdateMethod);
                }
                return updateCommand;
            }
        }

        public void DeleteMethod(object obj)
        {
            offers.DeleteMethod(obj);
            ErrorMessage = offers.ErrorMessage;
        }

        private ICommand deleteCommand;

        public ICommand DeleteCommand
        {
            get
            {
                if (deleteCommand == null)
                {
                    deleteCommand = new RelayCommand(DeleteMethod);
                }
                return deleteCommand;
            }
        }
        #endregion

    }
}
