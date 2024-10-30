using LibraryStstem.Logins;

namespace LibraryStstem.Permission
{
    static public class ManagePermissions
    {
        public enum enMainMenuPermission { Books = 1, Authors = 2, Customers = 4, Users = 8, Genres = 16, Fines = 32, Borrowing = 64, Reservations = 128,Logins=256 };
        public static bool CheckAccessPermission(enMainMenuPermission menuPermission)
        {
            if (frmMainLogin.CurrentUser.Permission == -1)
            {
                return true;
            }
            return (((int)menuPermission & frmMainLogin.CurrentUser.Permission) == (int)menuPermission);
        }
        public static bool CheckAccessPermission(int Permission_User, enMainMenuPermission menuPermission)
        {
            if (frmMainLogin.CurrentUser.Permission == -1)
            {
                return true;
            }
            return (((int)menuPermission & Permission_User) == (int)menuPermission);
        }
    }

}
