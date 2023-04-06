namespace CinemaApi.Entities.Entities
{
    public class Seat
    {
        public Seat(int row, int seatNumber)
        {
            Row = row;
            SeatNumber = seatNumber;
        }


        public int Id { get; set; }
        public int Row { get; set; }
        public int SeatNumber { get; set; }
        public bool IsTaken { get; set; } = false;
    }
}
