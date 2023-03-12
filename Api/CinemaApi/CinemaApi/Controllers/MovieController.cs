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

        public IEnumerable<Movie> GetAllMovies()
        {
            return _movieRepository.GetAllMovies();
        }

        [HttpGet("api/movies/{id}")]
        public Movie? GetMovieById(int id)
        {
            return _movieRepository.GetMovieById(id);
        }

    }
}
