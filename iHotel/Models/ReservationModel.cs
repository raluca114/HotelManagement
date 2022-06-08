using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace iHotel.Models
{
    public class ReservationModel
    {
        private HotelEntities context = new HotelEntities();

        public ObservableCollection<Reservation> ReservationsList { get; set; }

        public string ErrorMessage { get; set; }

        public void AddMethod(object obj)
        {
            Reservation reservation = obj as Reservation;
            reservation.state = "active";
            if (reservation != null)
            {
                if (string.IsNullOrEmpty(reservation.name))
                {
                    ErrorMessage = "Please select the date!";
                }
                else
                {
                    context.AddReservation(reservation.name, reservation.phone, reservation.check_in_date, reservation.check_out_date, reservation.room_type, reservation.state);
                    context.SaveChanges();
                    ReservationsList.Add(reservation);
                    ErrorMessage = "";
                }
            }

        }

        public void UpdateMethod(object obj)
        {
            Reservation reservation = obj as Reservation;
            if (reservation != null)
            {
                if (string.IsNullOrEmpty(reservation.name))
                {
                    ErrorMessage = "Please select a reservation!";
                }
                else
                {
                    context.UpdateReservation(reservation.state);
                    context.SaveChanges();
                    ErrorMessage = "";
                }
            }
        }

        public ObservableCollection<Reservation> GetAllReservationsUser()
        {
            List<Reservation> reservation = context.Reservations.ToList();
            ObservableCollection<Reservation> result = new ObservableCollection<Reservation>();
            foreach (Reservation reservation1 in reservation)
            {
                if (reservation1.state != "canceled")
                {
                    result.Add(reservation1);
                }
            }
            return result;
        }
        public ObservableCollection<Reservation> GetAllReservations()
        {
            List<Reservation> reservation = context.Reservations.ToList();
            ObservableCollection<Reservation> result = new ObservableCollection<Reservation>();
            foreach (Reservation reservation1 in reservation)
            {
                result.Add(reservation1);
            }
            return result;
        }
    }
}

