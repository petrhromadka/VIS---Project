using System.Data.Entity;
using CinemaApi.Args;
using CinemaApi.Entities.Context;
using CinemaApi.Entities.Entities;

namespace CinemaApi.Repository.Reservation
{
    using Reservation = Entities.Entities.Reservation;

    public class ReservationRepository : IReservationRepository
    {
        public CinemaApiContext _context;

        public ReservationRepository()
        {
            _context = new CinemaApiContext();
        }

        public void AddReservation(ReservationArgs args)
        {
            var reservation = CreateReservationFromArgs(args);
            ReserveSeats(reservation.EventId, args.Seats);
            reservation.Id = _context.Reservations.Count() + 1;

            _context.Reservations.Add(reservation);
            _context.SaveChanges();
        }

        private void ReserveSeats(int reservationEventId, List<Seat> argsSeats)
        {
            var dbSeats = _context.Events
                .Include(m => m.Hall)
                .Include(m => m.Hall.Seats)
                .AsQueryable()
                .First(x => x.Id == reservationEventId)
                .Hall
                .Seats
                .Where(dbSeat => argsSeats.Any(argsSeat => dbSeat.Id == argsSeat.Id));

            foreach (var dbSeat in dbSeats)
            {
                dbSeat.IsTaken = true;
            }

            _context.SaveChanges();
        }

        private Reservation CreateReservationFromArgs(ReservationArgs args)
        {
            return new Reservation
            {
                CustomerEmail = args.CustomerEmail,
                CustomerName = args.CustomerName,
                CustomerPhone = args.CustomerPhone,
                EventId = args.EventId,
                TotalPrice = args.TotalPrice,
                SeatReservations = string.Join(",", args.Seats)
            };
        }
    }
}
