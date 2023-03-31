using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using CinemaApi.Entities.Context;
using CinemaApi.Requests;
using CinemaApi.Results;
using Microsoft.IdentityModel.Tokens;

namespace CinemaApi.Repository.User
{
    using User = CinemaApi.Entities.Entities.User;

    public class UserRepository : IUserRepository
    {
        private readonly CinemaApiContext _context;
        private readonly IConfiguration _configuration;

        public UserRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _context = new CinemaApiContext();
        }

        public Task<Result> RegisterUser(UserRequest request)
        {
            var isUsernameTaken = _context.Users.AsEnumerable().Any(u => string.Equals(u.Username, request.Username, StringComparison.InvariantCultureIgnoreCase));
            if (isUsernameTaken)
            {
                return Task.FromResult<Result>(new AuthResult
                {
                    Token = null,
                    Message = $"Username {request.Username} is already taken"
                });
            }

            CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);

            var newUser = new User
            {
                Username = request.Username,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            };

            _context.Users.Add(newUser);
            _context.SaveChanges();

            return Task.FromResult<Result>(new AuthResult { Message = "User successfully registered", Token = CreateToken(request) });
        }

        public Task<Result> LoginUser(UserRequest request)
        {
            var usernameFound = _context.Users.AsEnumerable().Any(x => x.Username == request.Username);
            if (!usernameFound)
            {
                return Task.FromResult<Result>(new AuthResult { Message = $"Username {request.Username} was not found.", Token = null, });
            }

            var user = _context.Users.First(x => x.Username == request.Username);

            if (!PasswordHashVerified(request.Password, user.PasswordHash, user.PasswordSalt))
            {
                return Task.FromResult<Result>(new AuthResult { Message = "Wrong password", Token = null, });
            }

            return Task.FromResult<Result>(new AuthResult { Message = "Logged in successfully", Token = CreateToken(request) });
        }

        #region Helper methods

        private string CreateToken(UserRequest request)
        {
            var claims = new List<Claim>
            {
                new(ClaimTypes.Name, request.Username)
            };

            var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration.GetSection("Auth:Token").Value));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);


            var jwtToken = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(jwtToken);
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using var hmac = new HMACSHA256();
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(Encoding.ASCII.GetBytes(password));
        }

        private bool PasswordHashVerified(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using var hmac = new HMACSHA256(passwordSalt);
            var computedHash = hmac.ComputeHash(Encoding.ASCII.GetBytes(password));

            return computedHash.SequenceEqual(passwordHash);
        }

        #endregion
    }
}
