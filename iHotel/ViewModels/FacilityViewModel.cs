using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iHotel.Views;
using iHotel.Models;
using iHotel.Helpers;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace iHotel.ViewModels
{
    public class FacilityViewModel: BaseVM
    {
        private RoomFacilityModel facility;

        public FacilityViewModel()
        {
            facility = new RoomFacilityModel();
            FacilityList = facility.GetAllFacilities();
        }

        public ObservableCollection<Facility> FacilityList
        {
            get => facility.FacilitiesList;
            set => facility.FacilitiesList = value;
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

        #region Command Members
        public void AddMethod(object obj)
        {
            facility.AddMethod(obj);
            ErrorMessage =facility.ErrorMessage;
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
            facility.UpdateMethod(obj);
            ErrorMessage=facility.ErrorMessage;
        }

        private ICommand updateCommand;

        public ICommand UpdateCommand
        {
            get
            {
                if(updateCommand == null)
                {
                    updateCommand= new RelayCommand(UpdateMethod);
                }
                return updateCommand;
            }
        }

        public void DeleteMethod(object obj)
        {
            facility.DeleteMethod(obj);
            ErrorMessage = facility.ErrorMessage;
        }

        private ICommand deleteCommand;

        public ICommand DeleteCommand
        {
            get
            {
                if(deleteCommand == null)
                {
                    deleteCommand= new RelayCommand(DeleteMethod);
                }
                return deleteCommand;
            }
        }

        #endregion
    }
}
