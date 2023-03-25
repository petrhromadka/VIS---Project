using CinemaApi.Entities.Context;
using CinemaApi.Providers;
using CinemaApi.Repository.User.Data;
using CinemaApi.Results;

namespace CinemaApi.Repository.User
{
    using User = Entities.Entities.User;

    public class UserRepository : IUserRepository
    {
        private readonly CinemaApiContext _context;

        public UserRepository()
        {
            _context = new CinemaApiContext();
        }

        public Result RegisterUser(UserArgs args)
        {
            if (string.IsNullOrEmpty(args.Username) || string.IsNullOrEmpty(args.Password))
            {
                return new Result
                {
                    HasError = true,
                    Message = MessageProvider.RegistrationFailed_MissingData,
                    Outcome = OutcomeProvider.Generic_MissingData
                };
            }

            var userToRegister = CreateUserEntityFromUserArgs(args);

            var usernameExists = _context.Users.Any(dbUser => dbUser.Username.Equals(userToRegister.Username, StringComparison.InvariantCultureIgnoreCase));
            if (usernameExists)
            {
                return new Result
                {
                    HasError = true,
                    Message = MessageProvider.RegistrationFailed_UsernameTaken,
                    Outcome = OutcomeProvider.Registration_UsernameTaken
                };
            }

            _context.Users.Add(userToRegister);
            _context.SaveChanges();

            return new Result
            {
                HasError = false,
                Message = MessageProvider.Registration_Success,
                Outcome = OutcomeProvider.Registration_Success
            };
        }

        public Result LoginUser(UserArgs args)
        {
            throw new NotImplementedException();
        }



        #region Entity arg creation

        private static User CreateUserEntityFromUserArgs(UserArgs args)
        {
            return new User
            {
                Username = args.Username!,
                Password = args.Password!
            };
        }

        #endregion
    }
}
