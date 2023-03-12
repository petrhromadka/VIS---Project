namespace CinemaApi.Repository.Movie
{
    using Movie = CinemaApi.Entities.Entities.Movie;

    public interface IMovieRepository
    {
        IEnumerable<Movie> GetAllMovies();
        Movie? GetMovieById(int id);
    }
}
