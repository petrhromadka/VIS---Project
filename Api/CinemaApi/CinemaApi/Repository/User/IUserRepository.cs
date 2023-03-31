using CinemaApi.Requests;
using CinemaApi.Results;

namespace CinemaApi.Repository.User
{
    public interface IUserRepository
    {
        Task<Result> RegisterUser(UserRequest request);
        Task<Result> LoginUser(UserRequest request);
    }
}
