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
            string query = @"insert into Authors (Certificate,[Person Id],AdditionalDetails) values (@Certificate,@PersonId,@AdditionalDetails)
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
            string query = @"   update Authors set Certificate=@Certificate , [Person Id]=@PersonId,AdditionalDetails=@AdditionalDetails
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
            return GenericData.All("select * from View_Author_Details");
        }

\
    }
}
