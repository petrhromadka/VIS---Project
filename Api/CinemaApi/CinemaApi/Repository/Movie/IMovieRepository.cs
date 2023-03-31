namespace CinemaApi.Repository.Movie
{
    using Movie = CinemaApi.Entities.Entities.Movie;

    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetAllMovies();
        Task<Movie?> GetMovieById(int id);
    }
}
