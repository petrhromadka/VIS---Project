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
                    Message = MessageProvider.RegistrationFailed_MissingData(args.Username, args.Password),
                    Outcome = OutcomeProvider.Generic_MissingData
                };
            }

            var userToRegister = CreateUserEntityFromUserArgs(args);

            var usernameExists = _context.Users.Any(dbUser => dbUser.Username.Equals(userToRegister.Username, StringComparison.InvariantCultureIgnoreCase));
            if (usernameExists)
            {
                return new Result
                {
                    Message = MessageProvider.RegistrationFailed_UsernameTaken(userToRegister.Username),
                    Outcome = OutcomeProvider.Registration_UsernameTaken
                };
            }

            _context.Users.Add(userToRegister);
            _context.SaveChanges();

            return new Result
            {
                Message = MessageProvider.Registration_Success(userToRegister.Username),
                Outcome = OutcomeProvider.Registration_Success
            };
        }

        public Result LoginUser(UserArgs args)
        {
            var user = _context.Users.AsEnumerable()
                                     .FirstOrDefault(x => CredentialsMatched(args, x));

            if (user == null)
            {
                return new Result
                {
                    Message = MessageProvider.Login_Failed,
                    Outcome = OutcomeProvider.Login_Failed
                };
            }


            return new Result
            {
                Message = MessageProvider.Login_Success(user.Username),
                Outcome = OutcomeProvider.Login_Success,
            };
        }

        #region Helpers
        private static bool CredentialsMatched(UserArgs args, User x)
        {
            return x.Username == args.Username &&
                   x.Password == args.Password;
        }


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
