using CinemaApi.Repository.User;
using CinemaApi.Repository.User.Data;
using CinemaApi.Results;
using Microsoft.AspNetCore.Mvc;

namespace CinemaApi.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost("api/users/login")]
        public Result LoginUser(UserArgs args)
        {
            var result = _userRepository.LoginUser(args);
            return result;
        }

        [HttpPost("api/users/register")]
        public Result RegisterUser(UserArgs args)
        {
            var result = _userRepository.RegisterUser(args);
            return result;
        }
    }
}
