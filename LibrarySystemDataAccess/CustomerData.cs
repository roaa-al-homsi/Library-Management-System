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

        static public bool GetCustomerByCard(int LibraryCardNum, ref int Id, ref int PersonId, ref string FullName, ref DateTime BirthDate, ref string Country, ref string ContactInfo,
         ref string ImagePath)
        {
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"select * from View_Customers_Details where [Library Card Number] =@LibraryCardNum";

            bool IsFound = false;
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LibraryCardNum", LibraryCardNum);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    Id = (int)reader["Customer Id"];
                    PersonId = (int)reader["Person Id"];
                    FullName = (string)reader["Full Name"];
                    Country = (string)reader["Country"];
                    ContactInfo = (string)reader["Contact Info"];
                    ImagePath = reader["Image Path"] != DBNull.Value ? (string)reader["ImagePath"] : string.Empty;
                    BirthDate = reader["Birth Date"] != DBNull.Value ? (DateTime)reader["Birth Date"] : DateTime.MinValue;
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

        static public bool Exist(int Id)
        {
            return GenericData.Exist("select Found=1 from Customers where Id =@Id", "@Id", Id);
        }
    }
}
