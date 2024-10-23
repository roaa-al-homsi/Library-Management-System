using System;
using System.Data;
using System.Data.SqlClient;

namespace LibrarySystemDataAccess
{
    static public class ReservationData
    {
        static public int Add(int CustomerId, int CopyId, DateTime ReservationDate)
        {
            int NewIdRecord = 0;
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @" insert into Reservations ([Customer Id],[Copy Id],[Reservation Date])values(@CustomerId,@CopyId,@ReservationDate);
                           SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerId", CustomerId);
            command.Parameters.AddWithValue("@CopyId", CopyId);
            if (ReservationDate == DateTime.MinValue)
            {
                command.Parameters.AddWithValue("@ReservationDate", System.DBNull.Value);

            }
            else
            {
                command.Parameters.AddWithValue("@ReservationDate", ReservationDate);
            }
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
        static public bool Update(int Id, int CustomerId, int CopyId, DateTime ReservationDate)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @" update Reservations set [Customer Id]=@CustomerId,[Copy Id]=@CopyId,[Reservation Date]=@ReservationDate where Id=@Id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", Id);
            command.Parameters.AddWithValue("@CustomerId", CustomerId);
            command.Parameters.AddWithValue("@CopyId", CopyId);
            if (ReservationDate == DateTime.MinValue)
            {
                command.Parameters.AddWithValue("@ReservationDate", System.DBNull.Value);

            }
            else
            {
                command.Parameters.AddWithValue("@ReservationDate", ReservationDate);
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
            return GenericData.Delete("Delete Reservations where Id=@Id", "@Id", Id);
        }
        static public DataTable All()
        {
            return GenericData.All(" select *from Reservations");
        }
        static public bool Exist(int Id)
        {
            return GenericData.Exist("select Found=1 from Reservations where Id =@Id", "@Id", Id);
        }
        static public bool ExistByCustomerId(int CustomerId)
        {
            return GenericData.Exist("select Found=1 from Reservations where [Customer Id] =@CustomerId", "@CustomerId", CustomerId);
        }
        static public bool GetReservationRecordById(int Id, ref int CustomerId, ref int CopyId, ref DateTime ReservationDate)
        {
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"select * from Reservations where [Id] =@Id";

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
                    CopyId = (int)reader["Copy Id"];
                    CustomerId = (int)reader["Customer Id"];
                    ReservationDate = reader["Reservation Date"] == null ? DateTime.MinValue : (DateTime)reader["Reservation Date"];
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
