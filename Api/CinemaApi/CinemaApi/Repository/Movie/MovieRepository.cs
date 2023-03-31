using CinemaApi.Entities;
using CinemaApi.Entities.Context;

namespace CinemaApi.Repository.Movie
{
    using Movie = CinemaApi.Entities.Entities.Movie;

    public class MovieRepository : IMovieRepository
    {
        private readonly CinemaApiContext _context;

        public MovieRepository()
        {
            _context = new CinemaApiContext();
        }

        public Task<IEnumerable<Movie>> GetAllMovies()
        {
            var movies = _context.Movies.Include(TableNames.EventsTable)
                                                        .AsEnumerable();

            return Task.FromResult(movies);
        }

        public Task<Movie?> GetMovieById(int id)
        {
            var movie = _context.Movies.Include(TableNames.EventsTable).FirstOrDefault(movie => movie.Id == id);
            return Task.FromResult(movie);
        }
    }
}
