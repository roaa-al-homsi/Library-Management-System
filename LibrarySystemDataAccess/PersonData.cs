using System;
using System.Data.SqlClient;

namespace LibrarySystemDataAccess
{
    static public class PersonData
    {
        static public int Add(String Name, DateTime BirthDate, String Country, bool IsAuthor, bool IsCustomer, bool IsUser, string ContactInfo, string ImagePath)
        {
            int IdNewPerson = 0;

            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"insert into Persons([Full Name],[Birth Date],Country,[Is Author],[Is Customer],[Is User],[Contact Info],[Image Path])
             values (@Name,@BirthDate,@Country,@IsAuthor,@IsCustomer,@IsUser,@ContactInfo,@ImagePath)
                          SELECT SCOPE_IDENTITY();;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);

            command.Parameters.AddWithValue("@Country", Country);
            command.Parameters.AddWithValue("@IsAuthor", IsAuthor);
            command.Parameters.AddWithValue("@IsCustomer", IsCustomer);
            command.Parameters.AddWithValue("@IsUser", IsUser);
            command.Parameters.AddWithValue("@ContactInfo", ContactInfo);

            if (BirthDate != null)
            {
                command.Parameters.AddWithValue("@BirthDate", BirthDate);
            }
            else
            {
                command.Parameters.AddWithValue("@BirthDate", System.DBNull.Value);
            }


            if (ImagePath != null)
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    IdNewPerson = insertedID;
                }
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return IdNewPerson;
        }

        static public bool Delete(int Id)
        {
            return GenericData.Delete("delete Persons where Id =@Id", "@Id", Id);

        }

        static public bool Update(int Id, String Name, DateTime BirthDate, String Country, bool IsAuthor, bool IsCustomer, bool IsUser, string ContactInfo, string ImagePath)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"   update Persons set [Full Name] =@Name
				   ,[Birth Date] = @BirthDate ,Country=@Country,[Is Author]=@IsAuthor, [Is Customer] =@IsCustomer,[Is User]=@IsUser,[Contact Info]=@ContactInfo,[Image Path] =@ImagePath 
				   where Id=@Id;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Country", Country);
            command.Parameters.AddWithValue("@IsAuthor", IsAuthor);
            command.Parameters.AddWithValue("@IsCustomer", IsCustomer);
            command.Parameters.AddWithValue("@IsUser", IsUser);
            command.Parameters.AddWithValue("@ContactInfo", ContactInfo);
            command.Parameters.AddWithValue("@Id", Id);
            if (BirthDate != null)
            {
                command.Parameters.AddWithValue("@BirthDate", BirthDate);
            }
            else
            {
                command.Parameters.AddWithValue("@BirthDate", System.DBNull.Value);
            }


            if (ImagePath != null)
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
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

    }
}
