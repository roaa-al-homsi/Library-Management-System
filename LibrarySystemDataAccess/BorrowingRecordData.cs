using System;
using System.Data;
using System.Data.SqlClient;

namespace LibrarySystemDataAccess
{
    static public class BorrowingRecordData
    {
        static public int Add(int CopyId, int CustomerId, DateTime BorrowingDate, DateTime DueDate, DateTime ActualReturnDate)
        {
            int NewIdRecord = 0;
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"  insert into [Borrowing Records] ([Copy id],[Customer id],[Borrowing Date],[Due Date],[Actual Return Date])values (@CopyId,@CustomerId,@BorrowingDate,@DueDate,@ActualReturnDate)
                           SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CopyId", CopyId);
            command.Parameters.AddWithValue("@CustomerId", CustomerId);
            command.Parameters.AddWithValue("@BorrowingDate", BorrowingDate);
            command.Parameters.AddWithValue("@DueDate", DueDate);

            // Convert DateTime.MinValue to DBNull if needed
            //doesn't work
            //object sqlActualReturnDate = (ActualReturnDate == DateTime.MinValue) ? System.DBNull.Value : (object)ActualReturnDate;
            //command.Parameters.AddWithValue("@ActualReturnDate", sqlActualReturnDate);

            if (ActualReturnDate == DateTime.MinValue)
            {
                command.Parameters.AddWithValue("@ActualReturnDate", System.DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
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
        static public bool Update(int Id, int CopyId, int CustomerId, DateTime BorrowingDate, DateTime DueDate, DateTime ActualReturnDate)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"   update [Borrowing Records] set [Copy id]=@CopyId , [Customer id]=@CustomerId,[Borrowing Date]=@BorrowingDate,
				   [Due Date]=@DueDate,[Actual Return Date]=@ActualReturnDate where Id=@Id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", Id);
            command.Parameters.AddWithValue("@CopyId", CopyId);
            command.Parameters.AddWithValue("@CustomerId", CustomerId);
            command.Parameters.AddWithValue("@BorrowingDate", BorrowingDate);
            command.Parameters.AddWithValue("@DueDate", DueDate);

            if (ActualReturnDate == DateTime.MinValue)
            {
                command.Parameters.AddWithValue("@ActualReturnDate", System.DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
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
            return GenericData.Delete("Delete [Borrowing Records] where Id=@Id", "@Id", Id);
        }
        static public DataTable All()
        {
            return GenericData.All(" select *from [Borrowing Records]");
        }
        static public bool Exist(int Id)
        {
            return GenericData.Exist("select Found=1 from [Borrowing Records] where Id =@Id", "@Id", Id);
        }
        static public bool ExistByCustomerId(int CustomerId)
        {
            return GenericData.Exist("select Found=1 from [Borrowing Records] where [Customer id] =@CustomerId", "@CustomerId", CustomerId);
        }
        static public bool GetBorrowingRecordById(int Id, ref int CopyId, ref int CustomerId, ref DateTime BorrowingDate, ref DateTime DueDate, ref DateTime ActualReturnDate)
        {
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"select * from [Borrowing Records] where [Id] =@Id";

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
                    CopyId = (int)reader["Copy id"];
                    CustomerId = (int)reader["Customer id"];
                    BorrowingDate = (DateTime)reader["Borrowing Date"];
                    DueDate = (DateTime)reader["Due Date"];

                    ActualReturnDate = reader["Actual Return Date"] != DBNull.Value ? (DateTime)reader["Actual Return Date"] : DateTime.MinValue;
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
