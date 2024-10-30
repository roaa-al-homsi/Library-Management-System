using System.Data;

namespace LibrarySystemDataAccess
{
    static public class LoginData
    {
        static public DataTable All()
        {
            return GenericData.All("select * from View_Login_Details");
        }



    }
}
