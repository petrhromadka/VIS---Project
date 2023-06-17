using CinemaApi.Entities.Entities;

namespace CinemaApi.Args
{
    public class ReservationArgs
    {
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public int EventId { get; set; }

        public int TotalPrice { get; set; }
        public List<Seat> Seats { get; set; }
    }
}
