using System;
using System.Data.SqlClient;

namespace LibrarySystemDataAccess
{
    static public class PersonData
    {
        static public int Add(String Name, DateTime BirthDate, String Country, string ContactInfo, string ImagePath)
        {
            int IdNewPerson = 0;

            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"insert into Persons([Full Name],[Birth Date],Country,[Contact Info],[Image Path])
             values (@Name,@BirthDate,@Country,@ContactInfo,@ImagePath)
                          SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);

            command.Parameters.AddWithValue("@Country", Country);
            command.Parameters.AddWithValue("@ContactInfo", ContactInfo);

            if (BirthDate != null)
            {
                command.Parameters.AddWithValue("@BirthDate", BirthDate);
            }
            else
            {
                command.Parameters.AddWithValue("@BirthDate", System.DBNull.Value);
            }


            if (!string.IsNullOrWhiteSpace(ImagePath))
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

        static public bool Update(int Id, String Name, DateTime BirthDate, String Country, string ContactInfo, string ImagePath)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"   update Persons set [Full Name] =@Name
				   ,[Birth Date] = @BirthDate ,Country=@Country,[Contact Info]=@ContactInfo,[Image Path] =@ImagePath 
				   where Id=@Id;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Country", Country);
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


            if (!string.IsNullOrWhiteSpace(ImagePath))
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

        static public bool GetPersonById(int Id, ref String Name, ref DateTime BirthDate, ref String Country, ref string ContactInfo, ref string ImagePath)
        {
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"select * from Persons where Id =@Id";

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
                    Country = (string)reader["Country"];
                    ContactInfo = (string)reader["Contact Info"];
                    ImagePath = reader["Image Path"] != DBNull.Value ? (string)reader["ImagePath"] : string.Empty;
                    BirthDate = reader["Birth Date"] != DBNull.Value ? (DateTime)reader["Birth Date"] : DateTime.MinValue;
                    Name = (string)reader["Full Name"];

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
            return GenericData.Exist("select Found=1 from Persons where Id =@Id", "@Id", Id);
        }

    }
}
