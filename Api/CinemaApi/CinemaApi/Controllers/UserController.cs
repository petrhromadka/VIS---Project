using CinemaApi.Repository.User;
using CinemaApi.Requests;
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

        [HttpPost("auth/login")]
        public Result LoginUser(UserRequest request)
        {
            var result = _userRepository.LoginUser(request);
            return result.Result;
        }

        [HttpPost("auth/register")]
        public Result RegisterUser(UserRequest request)
        {
            var result = _userRepository.RegisterUser(request);
            return result.Result;
        }
    }
}
