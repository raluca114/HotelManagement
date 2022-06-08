using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iHotel.Models;
using iHotel.Views;
using iHotel.Helpers;
using System.Windows.Input;
using System.Data.SqlClient;

namespace iHotel.ViewModels
{
    public class PricesViewModel:BaseVM
    {
        private PriceModel prices;

        public PricesViewModel()
        {
            prices=new PriceModel();
            PricesList = prices.GetAllPrices();
        }

        #region Data Members

        public ObservableCollection<Price> PricesList
        {
            get => prices.PricesList;
            set=> prices.PricesList = value;
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
            prices.AddMethod(obj);
            ErrorMessage = prices.ErrorMessage;
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

        public void DeleteMethod(object obj)
        {
            prices.DeleteMethod(obj);
            ErrorMessage = prices.ErrorMessage;
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
