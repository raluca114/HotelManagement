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
    public class ServicesViewModel : BaseVM
    {
        private ServicesModel services;

        public ServicesViewModel()
        {
            services = new ServicesModel();
            ServicesList = services.GetAllServices();
        }

        #region Data Members
        public ObservableCollection<Service> ServicesList
        {
            get => services.ServicesList;
            set => services.ServicesList = value;
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
            services.AddMethod(obj);
            ErrorMessage = services.ErrorMessage;
        }
        private ICommand addCommand;

        public ICommand AddCommand
        {
            get
            {
                if(addCommand == null)
                {
                    addCommand = new RelayCommand(AddMethod);
                }
                return addCommand;
            }
        }
        public void UpdateMethod(object obj)
        {
            services.UpdateMethod(obj);
            ErrorMessage = services.ErrorMessage;
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
            services.DeleteMethod(obj);
            ErrorMessage = services.ErrorMessage;
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
