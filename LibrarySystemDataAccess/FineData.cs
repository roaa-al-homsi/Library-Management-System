using System;
using System.Data;
using System.Data.SqlClient;

namespace LibrarySystemDataAccess
{
    static public class FineData
    {
        static public int Add(int CustomerId, int BorrowingRecordId, decimal Amount, short NumberOfLateDays, bool PaymentStatus)
        {
            int NewIdRecord = 0;
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"insert into Fines ([Customer Id],[Borrowing Record Id],Amount,[Number Of Late Days],[Payment Status])values (@CustomerId,@BorrowingRecordId,@Amount,@NumberOfLateDays,@PaymentStatus)
                           SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerId", CustomerId);
            command.Parameters.AddWithValue("@BorrowingRecordId", BorrowingRecordId);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@NumberOfLateDays", NumberOfLateDays);
            command.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);
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
        static public bool Update(int Id, int CustomerId, int BorrowingRecordId, decimal Amount, short NumberOfLateDays, bool PaymentStatus)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"   update Fines set [Customer Id]=@CustomerId ,[Borrowing Record Id]=@BorrowingRecordId,Amount=@Amount,
				   [Number Of Late Days]=@NumberOfLateDays,[Payment Status]=@PaymentStatus where Id=@Id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", Id);
            command.Parameters.AddWithValue("@CustomerId", CustomerId);
            command.Parameters.AddWithValue("@BorrowingRecordId", BorrowingRecordId);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@NumberOfLateDays", NumberOfLateDays);
            command.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);
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
            return GenericData.Delete("Delete Fines where Id=@Id", "@Id", Id);
        }
        static public DataTable All()
        {
            return GenericData.All(" select *from Fines");
        }
        static public bool Exist(int Id)
        {
            return GenericData.Exist("select Found=1 from Fines where Id =@Id", "@Id", Id);
        }
        static public bool ExistFineByCustomerId(int CustomerId)
        {
            return GenericData.Exist("select Found=1 from Fines where [Customer Id] =@CustomerId", "@CustomerId", CustomerId);
        }
        static public bool GetFineById(int Id, ref int CustomerId, ref int BorrowingRecordId, ref decimal Amount, ref short NumberOfLateDays, ref bool PaymentStatus)
        {
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"select * from Fines where [Id] =@Id";

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
                    BorrowingRecordId = (int)reader["Borrowing Record Id"];
                    CustomerId = (int)reader["Customer id"];
                    Amount = (decimal)reader["Amount"];
                    NumberOfLateDays = (short)reader["Number Of Late Days"];
                    PaymentStatus = (bool)reader["Payment Status"];
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
