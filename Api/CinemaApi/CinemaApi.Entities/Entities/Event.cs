using System.ComponentModel.DataAnnotations;

namespace CinemaApi.Entities.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public DateTime DateTime { get; set; }
        public int Price { get; set; }
    }
}
