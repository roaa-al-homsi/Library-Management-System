using System;
using System.Data;
using System.Data.SqlClient;

namespace LibrarySystemDataAccess
{
    static public class GenreData
    {
        static public int Add(int Id, string Name)
        {
            int NewIdRecord = 0;
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"insert into Genres (Name)values(@Name)
                           SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);
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
        static public bool Update(int Id, string Name)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"update Genres set Name=@Name where Id=@Id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", Id);
            command.Parameters.AddWithValue("@Name", Name);
            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();
            }
            catch { Exception exception; }
            finally { connection.Close(); }
            return RowAffected > 0;
        }
        static public bool Delete(int Id)
        {
            return GenericData.Delete("Delete Genres where Id=@Id", "@Id", Id);
        }
        static public DataTable All()
        {
            return GenericData.All(" select *from Genres");
        }
        static public bool Exist(int Id)
        {
            return GenericData.Exist("select Found=1 from Genres where Id =@Id", "@Id", Id);
        }
        static public bool GetGenreById(int Id, ref string Name)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"select * from Genres where Id =@Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", Id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    Name = (string)reader["Name"];
                }
                else
                {
                    IsFound = false;
                }
                reader.Close();
            }
            catch { Exception exception; }
            finally { connection.Close(); }
            return IsFound;
        }
        static public string GetNameGenreById(int Id)
        {
            string GenreName = string.Empty;
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"select Name from Genres where Id =@Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", Id);
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null)
                {
                    GenreName = Result.ToString();
                }
            }
            catch { Exception exception; }
            finally { connection.Close(); }
            return GenreName;
        }
        static public DataTable GetGenresNames()
        {
            return GenericData.All("select Name from Genres");
        }
        static public int GetGenreIdByName(string Name)
        {
            int GenreID = 0;
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"select Id from Genres where Name=@Name";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int insertedId))
                {
                    GenreID = insertedId;
                }
            }
            catch { Exception exception; }
            finally { connection.Close(); }
            return GenreID;
        }
    }
}
