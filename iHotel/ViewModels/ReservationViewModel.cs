using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using iHotel.Helpers;
using iHotel.Models;

namespace iHotel.ViewModels
{
    public class ReservationViewModel : BaseVM
    {
        private ReservationModel reservations;

        public ReservationViewModel()
        {
            reservations = new ReservationModel();
            ReservationsList = reservations.GetAllReservations();
        }

        #region Data Members
        public ObservableCollection<Reservation> ReservationsList
        {
            get => reservations.ReservationsList;
            set => reservations.ReservationsList = value;
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
            reservations.AddMethod(obj);
            ErrorMessage = reservations.ErrorMessage;
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
            reservations.UpdateMethod(obj);
            ErrorMessage = reservations.ErrorMessage;
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

        
        #endregion
    }
}


