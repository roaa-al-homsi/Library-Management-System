using System.Configuration;

namespace LibrarySystemDataAccess
{
    public static class SettingData
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

    }
}
