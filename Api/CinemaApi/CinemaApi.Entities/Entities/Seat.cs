namespace CinemaApi.Entities.Entities
{
    public class Seat
    {
        public Seat()
        {
            
        }

        public int Id { get; set; }
        public int Row { get; set; }
        public int SeatNumber { get; set; }
        public bool IsTaken { get; set; } = false;
    }
}
