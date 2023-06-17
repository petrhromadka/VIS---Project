using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaApi.Entities.Entities
{
    public class Reservation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }

        public int EventId { get; set; }
        public int TotalPrice { get; set; }
        public string SeatReservations { get; set; }
    }
}
