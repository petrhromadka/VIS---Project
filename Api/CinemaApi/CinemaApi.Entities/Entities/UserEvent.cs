namespace CinemaApi.Entities.Entities
{
    public class UserEvent
    {
        public int Id { get; set; }
        public Event Event { get; set; }
        public Seat Seat { get; set; }
    }
}
