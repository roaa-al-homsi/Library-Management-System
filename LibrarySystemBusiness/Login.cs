using LibrarySystemDataAccess;

using System.Data;

namespace LibrarySystemBusiness
{
    public class Login
    {
        static public DataTable All()
        {
            return LoginData.All();
        }


    }
}
