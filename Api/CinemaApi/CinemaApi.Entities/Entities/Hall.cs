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
        public ICollection<Seat> Seats { get; } = GetSeatingPlan();

        public static ICollection<Seat> GetSeatingPlan()
        {
            return new Collection<Seat>()
            {
                new(1, 1),
                new(1, 2),
                new(1, 3),
                new(1, 4),
                new(1, 5),
                new(1, 6),
                new(1, 7),
                new(1, 8),
                new(1, 9),
                new(1, 10),
                new(2, 1),
                new(2, 2),
                new(2, 3),
                new(2, 4),
                new(2, 5),
                new(2, 6),
                new(2, 7),
                new(2, 8),
                new(2, 9),
                new(2, 10),
                new(3, 1),
                new(3, 2),
                new(3, 3),
                new(3, 4),
                new(3, 5),
                new(3, 6),
                new(3, 7),
                new(3, 8),
                new(3, 9),
                new(3, 10),
                new(4, 1),
                new(4, 2),
                new(4, 3),
                new(4, 4),
                new(4, 5),
                new(4, 6),
                new(4, 7),
                new(4, 8),
                new(4, 9),
                new(4, 10),
                new(5, 1),
                new(5, 2),
                new(5, 3),
                new(5, 4),
                new(5, 5),
                new(5, 6),
                new(5, 7),
                new(5, 8),
                new(5, 9),
                new(5, 10),
                new(6, 1),
                new(6, 2),
                new(6, 3),
                new(6, 4),
                new(6, 5),
                new(6, 6),
                new(6, 7),
                new(6, 8),
                new(6, 9),
                new(6, 10),
                new(7, 1),
                new(7, 2),
                new(7, 3),
                new(7, 4),
                new(7, 5),
                new(7, 6),
                new(7, 7),
                new(7, 8),
                new(7, 9),
                new(7, 10),
                new(8, 1),
                new(8, 2),
                new(8, 3),
                new(8, 4),
                new(8, 5),
                new(8, 6),
                new(8, 7),
                new(8, 8),
                new(8, 9),
                new(8, 10),
                new(9, 1),
                new(9, 2),
                new(9, 3),
                new(9, 4),
                new(9, 5),
                new(9, 6),
                new(9, 7),
                new(9, 8),
                new(9, 9),
                new(9, 10),
                new(10, 1),
                new(10, 2),
                new(10, 3),
                new(10, 4),
                new(10, 5),
                new(10, 6),
                new(10, 7),
                new(10, 8),
                new(10, 9),
                new(10, 10)
            };

        }
    }
}
