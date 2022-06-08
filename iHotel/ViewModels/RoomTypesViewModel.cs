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
    public class RoomTypesViewModel : BaseVM
    {

        private RoomTypeModel roomTypes;

        public RoomTypesViewModel()
        {
            roomTypes = new RoomTypeModel();
            RoomTypesList = roomTypes.GetAllRoomTypes();
         
        }

        #region Data Members
        public ObservableCollection<RoomType> RoomTypesList
        {
            get => roomTypes.RoomTypeList;
            set => roomTypes.RoomTypeList = value;
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
            roomTypes.AddMethod(obj);
            ErrorMessage = roomTypes.ErrorMessage;
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
            roomTypes.UpdateMethod(obj);
            ErrorMessage = roomTypes.ErrorMessage;
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
            roomTypes.DeleteMethod(obj);
            ErrorMessage = roomTypes.ErrorMessage;
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
