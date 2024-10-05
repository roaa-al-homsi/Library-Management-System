using System;
using System.Data;
using System.Data.SqlClient;

namespace LibrarySystemDataAccess
{
    static public class CustomerData
    {
        static public int Add(int LibraryCardNumber, int PersonId)
        {
            int NewIdCustomer = 0;
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"insert into Customers ([Library Card Number],[Person Id]) values (@LibraryCardNumber,@PersonId)
                           SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LibraryCardNumber", LibraryCardNumber);
            command.Parameters.AddWithValue("@PersonId", PersonId);
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

        static public bool Update(int Id, int LibraryCardNumber, int PersonId)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"   update Customers set [Library Card Number]=@LibraryCardNumber , [Person Id]=@PersonId
				   where Id=@Id;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LibraryCardNumber", LibraryCardNumber);
            command.Parameters.AddWithValue("@PersonId", PersonId);
            command.Parameters.AddWithValue("@Id", Id);
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
            return GenericData.Delete("Delete Customers where Id=@Id", "@Id", Id);
        }

        static public DataTable All()
        {
            return GenericData.All("select * from View_Customers_Details");
        }



    }
}
