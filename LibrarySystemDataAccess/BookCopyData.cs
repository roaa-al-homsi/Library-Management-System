using System;
using System.Data;
using System.Data.SqlClient;

namespace LibrarySystemDataAccess
{
    public static class BookCopyData
    {
        static public int Add(int BookId, bool AvailabilityStatus)
        {
            int NewIdBook = 0;
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"insert into BookCopies ([Book Id],[Availability Status])values(@BookId,@AvailabilityStatus);
                           SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookId", BookId);
            command.Parameters.AddWithValue("@AvailabilityStatus", AvailabilityStatus);
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int insertedId))
                {
                    NewIdBook = insertedId;
                }
            }
            catch { }
            finally { connection.Close(); }
            return NewIdBook;
        }

        static public bool Update(int Id, int BookId, bool AvailabilityStatus)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"update BookCopies set [Book Id]=@BookId,[Availability Status]=@AvailabilityStatus where Id = @Id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", Id);
            command.Parameters.AddWithValue("@BookId", BookId);
            command.Parameters.AddWithValue("@AvailabilityStatus", AvailabilityStatus);
            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();
            }
            catch { Exception exception; }
            finally { connection.Close(); }
            return RowAffected > 0;
        }

        public static bool Delete(int Id)
        {
            return GenericData.Delete("delete BookCopies where Id=@Id", "@Id", Id);
        }

        public static DataTable All()
        {
            return GenericData.All(" select *from View_BookCopy_Details");
        }

        public static bool Exist(int Id)
        {
            return GenericData.Exist("select found=1 from BookCopies where Id=@Id", "@Id", Id);
        }

        public static bool GetBookCopy(int Id, ref int BookId, ref bool AvailabilityStatus)
        {
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"select * from BookCopies where [Id] =@Id";

            bool IsFound = false;
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", Id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    BookId = (int)reader["Book Id"];
                    AvailabilityStatus = (bool)reader["Availability Status"];
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



    }

}
