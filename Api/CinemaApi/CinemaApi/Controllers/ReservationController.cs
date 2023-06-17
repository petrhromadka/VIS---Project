using CinemaApi.Args;
using CinemaApi.Entities.Entities;
using CinemaApi.Repository.Reservation;
using Microsoft.AspNetCore.Mvc;

namespace CinemaApi.Controllers
{
    [ApiController]
    public class ReservationController
    {
        private readonly IReservationRepository _reservationRepository;

        public ReservationController(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        [HttpPost("api/reservation/create")]
        public void AddReservation(ReservationArgs reservationArgs)
        {
            _reservationRepository.AddReservation(reservationArgs);
        } 
    }
}
