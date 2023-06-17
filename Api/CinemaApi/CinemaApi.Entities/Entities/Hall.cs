using CinemaApi.Entities.Mock;
using System.Collections.ObjectModel;

namespace CinemaApi.Entities.Entities
{
    public class Hall
    {
        public Hall(string name)
        {
            Name = name;
        }

        public Hall()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seat> Seats { get; set; }

    }
}
