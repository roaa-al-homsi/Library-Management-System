using System;
using System.Data;
using System.Data.SqlClient;

namespace LibrarySystemDataAccess
{
    static public class LoginData
    {
        static public DataTable All()
        {
            return GenericData.All("select * from View_Login_Details");
        }
        static public int Add(int UserId, DateTime LoginDate, DateTime LogoutDate)
        {
            int NewIdRecord = 0;
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"insert into Logins ([User Id],[Login Date],[Logout Date])values (@UserId,@LoginDate,@LoginDate)
                           SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserId", UserId);
            command.Parameters.AddWithValue("@LoginDate", LoginDate);
            command.Parameters.AddWithValue("@LogoutDate", LogoutDate);
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int insertedId))
                {
                    NewIdRecord = insertedId;
                }
            }
            catch { }
            finally { connection.Close(); }
            return NewIdRecord;
        }

    }
}
