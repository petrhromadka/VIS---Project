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

        public IEnumerable<Movie> GetAllMovies()
        {
            return _context.Movies.Include("Events").ToList();
        }

        public Movie? GetMovieById(int id)
        {
            return _context.Movies.Include("Events").FirstOrDefault(movie => movie.Id == id);
        }
    }
}
