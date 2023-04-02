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
                new()
                {
                    Title = "ANT-MAN A WASP: QUANTUMANIA",
                    Rating = 12,
                    Genre = Genre.Action,
                    Duration = 125,
                    Director = "Peyton Reed",
                    Thumbnail =
                        "https://image.pmgstatic.com/cache/resized/w1989/files/images/film/posters/167/104/167104672_124085.jpg",
                    Events = new List<Event>
                    {
                        new() { DateTime = new DateTime(2023, 3, 13, 14, 20, 0), Price = 180, Hall = "Sál 01" },
                        new() { DateTime = new DateTime(2023, 3, 13, 17, 10, 0), Price = 180, Hall = "Sál 02" },
                        new() { DateTime = new DateTime(2023, 3, 13, 20, 30, 0), Price = 180, Hall = "Sál 01" },
                        new() { DateTime = new DateTime(2023, 3, 14, 14, 20, 0), Price = 180, Hall = "Sál 01" },
                        new() { DateTime = new DateTime(2023, 3, 14, 17, 10, 0), Price = 180, Hall = "Sál 01" },
                        new() { DateTime = new DateTime(2023, 3, 14, 20, 30, 0), Price = 180, Hall = "Sál 01" },
                        new() { DateTime = new DateTime(2023, 3, 15, 14, 20, 0), Price = 180, Hall = "Sál 02" },
                        new() { DateTime = new DateTime(2023, 3, 15, 17, 10, 0), Price = 180, Hall = "Sál 01" },
                        new() { DateTime = new DateTime(2023, 3, 15, 21, 40, 0), Price = 180, Hall = "Sál 01" },
                    }
                },
                new()
                {
                    Title = "ASTERIX A OBELIX: ŘÍŠE STŘEDU",
                    Rating = 0,
                    Genre = Genre.Comedy,
                    Duration = 114,
                    Director = "Guillaume Canet",
                    Thumbnail =
                        "https://image.pmgstatic.com/cache/resized/w663/files/images/film/posters/166/707/166707979_0c329c.jpg",
                    Events = new List<Event>
                    {
                        new() { DateTime = new DateTime(2023, 3, 13, 15, 10, 0), Price = 160, Hall = "Sál 02" },
                        new() { DateTime = new DateTime(2023, 3, 14, 15, 10, 0), Price = 160, Hall = "Sál 02" },
                        new() { DateTime = new DateTime(2023, 3, 15, 15, 10, 0), Price = 160, Hall = "Sál 01" },
                    }
                },
                new()
                {
                    Title = "John Wick: Kapitola 4",
                    Rating = 15,
                    Genre = Genre.Action,
                    Duration = 169,
                    Director = "Chad Stahelski",
                    Thumbnail =
                        "https://image.pmgstatic.com/cache/resized/w663/files/images/film/posters/167/176/167176646_25e339.jpg",
                    Events = new List<Event>
                    {
                        new() { DateTime = new DateTime(2023, 3, 16, 15, 0, 0), Price = 180, Hall = "Sál 01" },
                        new() { DateTime = new DateTime(2023, 3, 17, 15, 0, 0), Price = 180, Hall = "Sál 01" },
                        new() { DateTime = new DateTime(2023, 3, 18, 17, 0, 0), Price = 180, Hall = "Sál 01" },
                        new() { DateTime = new DateTime(2023, 3, 19, 20, 0, 0), Price = 180, Hall = "Sál 01" },
                    }
                },

                new()
                {
                    Title = "Buď chlap!",
                    Rating = 0,
                    Genre = Genre.Romance,
                    Duration = 96,
                    Director = "Michal Samir",
                    Thumbnail =
                        "https://image.pmgstatic.com/cache/resized/w663/files/images/film/posters/167/079/167079369_57f236.jpg",
                    Events = new List<Event>
                    {
                        new() { DateTime = new DateTime(2023, 3, 16, 18, 0, 0), Price = 180, Hall = "Sál 01" },
                        new() { DateTime = new DateTime(2023, 3, 17, 18, 0, 0), Price = 180, Hall = "Sál 01" },
                        new() { DateTime = new DateTime(2023, 3, 18, 20, 0, 0), Price = 180, Hall = "Sál 01" },
                        new() { DateTime = new DateTime(2023, 3, 19, 18, 0, 0), Price = 180, Hall = "Sál 01" },
                        new() { DateTime = new DateTime(2023, 3, 20, 16, 0, 0), Price = 180, Hall = "Sál 01" },
                    }
                }


            };
        }
    }
}
