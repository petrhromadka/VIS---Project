using System.Data.Entity;
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

        public async Task<IEnumerable<Movie>> GetAllMovies()
        {
            var movies = await _context.Movies.ToListAsync();
            return movies;
        }

        public async Task<Movie?> GetMovieById(int id)
        {
            var movie = await _context.Movies.Include(m => m.Events.Select(e => e.Hall))
                                              .AsQueryable()
                                             .FirstOrDefaultAsync(movie => movie.Id == id);

            return movie;
        }
    }
}
