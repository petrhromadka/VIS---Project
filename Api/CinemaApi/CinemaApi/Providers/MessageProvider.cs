namespace CinemaApi.Providers
{
    public abstract class MessageProvider
    {
        #region
        public static string RegistrationFailed_MissingData => "Username or password is missing.";
        public static string RegistrationFailed_UsernameTaken => "Username is already taken.";
        public static string Registration_Success => "User registered successfully.";

        #endregion
    }
}
