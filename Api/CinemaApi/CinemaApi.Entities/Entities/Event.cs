using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaApi.Entities.Entities
{
    public class Event
    {
        public int Id { get; set; }

        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }


        public DateTime DateTime { get; set; }
        public int Price { get; set; }
    }
}
