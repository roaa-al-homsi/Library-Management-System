using System;
using System.Data;
using System.Data.SqlClient;

namespace LibrarySystemDataAccess
{
    static public class AuthorData
    {
        static public int Add(string Certificate, int PersonId, string AdditionalDetails)
        {
            int NewIdCustomer = 0;
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"insert into Authors (Certificate,[Person Id],[Additional Details]) values (@Certificate,@PersonId,@AdditionalDetails)
                           SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonId", PersonId);

            if (Certificate != null)
            {
                command.Parameters.AddWithValue("@Certificate", Certificate);

            }
            else
            {
                command.Parameters.AddWithValue("@Certificate", System.DBNull.Value);
            }

            if (AdditionalDetails != null)
            {
                command.Parameters.AddWithValue("@AdditionalDetails", AdditionalDetails);

            }
            else
            {
                command.Parameters.AddWithValue("@AdditionalDetails", System.DBNull.Value);
            }

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int insertedId))
                {
                    NewIdCustomer = insertedId;
                }
            }
            catch { }
            finally { connection.Close(); }
            return NewIdCustomer;
        }

        static public bool Update(int Id, string Certificate, int PersonId, string AdditionalDetails)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"   update Authors set Certificate=@Certificate , [Person Id]=@PersonId,[Additional Details]=@AdditionalDetails
				   where Id=@Id;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonId", PersonId);
            command.Parameters.AddWithValue("@Id", Id);

            if (Certificate != null)
            {
                command.Parameters.AddWithValue("@Certificate", Certificate);

            }
            else
            {
                command.Parameters.AddWithValue("@Certificate", System.DBNull.Value);
            }

            if (AdditionalDetails != null)
            {
                command.Parameters.AddWithValue("@AdditionalDetails", AdditionalDetails);

            }
            else
            {
                command.Parameters.AddWithValue("@AdditionalDetails", System.DBNull.Value);
            }
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
            return GenericData.Delete("Delete Authors where Id=@Id", "@Id", Id);
        }
        static public DataTable All()
        {
            return GenericData.All(" select * from View_Author_Details");
        }
        static public DataTable GetAuthorsNames()
        {
            return GenericData.All("select [Full Name] from View_Author_Details");
        }
        static public bool GetAuthorById(int Id, ref int PersonId, ref string Certificate, ref string AdditionalDetails)
        {
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"select * from Authors where [Id] =@Id";

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
                    Id = (int)reader["Id"];
                    PersonId = (int)reader["Person Id"];
                    AdditionalDetails = reader["Additional Details"] != DBNull.Value ? (string)reader["Additional Details"] : string.Empty;
                    Certificate = reader["Certificate"] != DBNull.Value ? (string)reader["Certificate"] : string.Empty;
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
        static public int GetAuthorIdByName(string Name)
        {
            int AuthorID = 0;
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"select [Author Id] from View_Author_Details where [Full Name] =@Name";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int insertedId))
                {
                    AuthorID = insertedId;
                }
            }
            catch { Exception exception; }
            finally { connection.Close(); }
            return AuthorID;
        }
        static public string GetNameAuthorById(int Id)
        {
            string AuthorName = string.Empty;
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"select [Full Name] from View_Author_Details where [Author Id] =@Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", Id);
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null)
                {
                    AuthorName = Result.ToString();
                }
            }
            catch { Exception exception; }
            finally { connection.Close(); }
            return AuthorName;
        }
        static public bool Exist(int Id)
        {
            return GenericData.Exist("select Found=1 from Authors where Id =@Id", "@Id", Id);
        }

    }
}
