using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaApi.Entities.Entities
{
    public class Event
    {
        public Event(Hall hall, int price, DateTime dateTime)
        {
            Hall = hall;
            Price = price;
            DateTime = dateTime;
        }

        public Event()
        {
            
        }

        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public Hall Hall { get; set; }
        public int Price { get; set; }
    }
}
