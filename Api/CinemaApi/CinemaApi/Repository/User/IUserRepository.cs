using CinemaApi.Repository.User.Data;
using CinemaApi.Results;

namespace CinemaApi.Repository.User
{
    public interface IUserRepository
    {
        Result RegisterUser(UserArgs args);
        Result LoginUser(UserArgs args);
    }
}
