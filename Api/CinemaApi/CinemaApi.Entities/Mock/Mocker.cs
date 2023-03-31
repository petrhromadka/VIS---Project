using CinemaApi.Entities.Entities;
using CinemaApi.Entities.Enums;

namespace CinemaApi.Entities.Mock
{
    public class Mocker
    {
        public static IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie()
                {
                    Title = "ANT-MAN A WASP: QUANTUMANIA",
                    Rating = 12,
                    Genre = Genre.Action,
                    Duration = 125,
                    Director = "Peyton Reed",
                    Events = new List<Event>()
                    {
                        new() { DateTime = new DateTime(2023, 3, 13, 14, 20, 0), Price = 180 },
                        new() { DateTime = new DateTime(2023, 3, 13, 17, 10, 0), Price = 180 },
                        new() { DateTime = new DateTime(2023, 3, 13, 20, 30, 0), Price = 180 },
                        new() { DateTime = new DateTime(2023, 3, 14, 14, 20, 0), Price = 180 },
                        new() { DateTime = new DateTime(2023, 3, 14, 17, 10, 0), Price = 180 },
                        new() { DateTime = new DateTime(2023, 3, 14, 20, 30, 0), Price = 180 },
                        new() { DateTime = new DateTime(2023, 3, 15, 14, 20, 0), Price = 180 },
                        new() { DateTime = new DateTime(2023, 3, 15, 17, 10, 0), Price = 180 },
                        new() { DateTime = new DateTime(2023, 3, 15, 21, 40, 0), Price = 180 },
                    }
                },
                new Movie()
                {
                    Title = "ASTERIX A OBELIX: ŘÍŠE STŘEDU",
                    Rating = 0,
                    Genre = Genre.Comedy,
                    Duration = 114,
                    Director = "Guillaume Canet",
                    Events = new List<Event>()
                    {
                        new() { DateTime = new DateTime(2023, 3, 13, 15, 10, 0), Price = 160 },
                        new() { DateTime = new DateTime(2023, 3, 14, 15, 10, 0), Price = 160 },
                        new() { DateTime = new DateTime(2023, 3, 15, 15, 10, 0), Price = 160 },
                    }
                },


            };
        }
    }
}
