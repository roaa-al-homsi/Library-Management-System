using LibraryStstem.Login;

namespace LibraryStstem.Permission
{
    static public class ManagePermissions
    {
        public enum enMainMenuPermission { Books = 1, Authors = 2, Customers = 4, Users = 8, Genres = 16, Fines = 32, Borrowing = 64, Reservations = 128 };
        public static bool CheckAccessPermission(enMainMenuPermission menuPermission)
        {
            if (frmMainLogin.CurrentUser.Permission == -1)
            {
                return true;
            }
            return (((int)menuPermission & frmMainLogin.CurrentUser.Permission) == (int)menuPermission);
        }

    }

}
