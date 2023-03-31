// ReSharper disable InconsistentNaming
namespace CinemaApi.Providers
{
    public abstract class OutcomeProvider
    {
        public static string Generic_MissingData => "MissingData";

        #region Registration
        public static string Registration_UsernameTaken => "UsernameTaken";
        public static string Registration_Success => "Registration_Success";
        #endregion

        #region Login

        public static string Login_Failed => "LoginFailed";
        public static string Login_Success => "LoginSuccess";

        #endregion
    }
}
