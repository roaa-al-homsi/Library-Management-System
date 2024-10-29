using System;
using System.Data;
using System.Data.SqlClient;

namespace LibrarySystemDataAccess
{
    static public class CustomerData
    {
        static public int Add(string LibraryCardNumber, int PersonId)
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

        static public bool Update(int Id, string LibraryCardNumber, int PersonId)
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
        static public DataTable ViewSpecificCustomer(int CustomerId)
        {
            return GenericData.ShowDataForSpecificObject("select * from View_Customers_Details where [Customer Id]=@CustomerId", "@CustomerId", CustomerId);

        }
        static public bool GetCustomerByCard(string LibraryCardNum, ref int Id, ref int PersonId)

        {
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"select * from Customers where [Library Card Number] =@LibraryCardNum";

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
                    Id = (int)reader["Id"];
                    PersonId = (int)reader["Person Id"];
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
        static public bool GetCustomerById(int Id, ref string LibraryCardNum, ref int PersonId)

        {
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"select * from Customers where Id =@Id";

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
                    PersonId = (int)reader["Person Id"];
                    LibraryCardNum = (string)reader["Library Card Number"];
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
        static public int GetPersonIdByCustomerId(int CustomerId)
        {
            int PersonID = 0;
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"select [Person Id] from Customers where Id =@CustomerId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerId", CustomerId);
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int insertedId))
                {
                    PersonID = insertedId;
                }
            }
            catch { Exception exception; }
            finally { connection.Close(); }
            return PersonID;
        }
        static public bool Exist(int Id)
        {
            return GenericData.Exist("select Found=1 from Customers where Id =@Id", "@Id", Id);
        }
        static public bool ExistByCard(string LibCard)
        {
            return GenericData.Exist("select Found=1 from Customers where [Library Card Number] =@LibCard", "@LibCard", LibCard);
        }
    }
}
