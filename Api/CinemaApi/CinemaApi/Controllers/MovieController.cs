using CinemaApi.Entities.Entities;
using CinemaApi.Repository.Movie;
using Microsoft.AspNetCore.Mvc;

namespace CinemaApi.Controllers
{
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository _movieRepository;

        public MovieController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [HttpGet("api/movies")]
        public IEnumerable<Movie> GetAllMovies()
        {
            var movies = _movieRepository.GetAllMovies();
            return movies.Result;
        }

        [HttpGet("api/movies/{id}")]
        public Movie? GetMovieById(int id)
        {
            var movie = _movieRepository.GetMovieById(id);
            return movie.Result;
        }

    }
}
