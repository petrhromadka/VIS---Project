// ReSharper disable StringLiteralTypo
// ReSharper disable InconsistentNaming

using CinemaApi.Enums;

namespace CinemaApi.Providers
{
    public abstract class MessageProvider
    {
        #region Messages

        #region Registration Messages
        public static string RegistrationFailed_MissingData(string? username, string? password) => GetRegistrationMissingDataMessage(username, password);
        public static string RegistrationFailed_UsernameTaken(string username) => $"Uživatelské jméno '{username}' je zabráno.";
        public static string Registration_Success(string username) => $"Uživatel {username} byl úspěšně zaregistrován.";

        #endregion

        #region Login messages

        public static string Login_Success(string username) => $"Uživatel {username} byl přihlášen.";
        public static string Login_Failed => "Chybně zadané heslo nebo uživatelské jméno";

        #endregion


        #endregion

        #region Methods

        private static string GetRegistrationMissingDataMessage(string? username, string? password)
        {
            var missingType = FindWhatIsMissing(username, password);

            return missingType switch
            {
                MissingData.Username => "Uživatelské jméno nebylo zadáno.",
                MissingData.Password => "Uživatelské heslo nebylo zadáno,",
                _ => "Nebyly zadány žádné uživatelské údaje."
            };
        }

        private static MissingData FindWhatIsMissing(string? username, string? password)
        {
            return string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password) ? MissingData.UsernameAndPassword :
                string.IsNullOrEmpty(username) ? MissingData.Username : MissingData.Password;

        }

        #endregion
    }
}
