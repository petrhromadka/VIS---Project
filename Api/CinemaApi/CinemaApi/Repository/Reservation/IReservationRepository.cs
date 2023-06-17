using CinemaApi.Args;

namespace CinemaApi.Repository.Reservation
{
    public interface IReservationRepository
    {
        void AddReservation(ReservationArgs reservationArgs);
    }
}
