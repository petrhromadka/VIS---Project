using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaApi.Entities.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int Price { get; set; }
    }
}
