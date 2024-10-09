using System;
using System.Data;
using System.Data.SqlClient;

namespace LibrarySystemDataAccess
{
    static public class BookData
    {

        static public int Add(string Title, string ISBN, int PublicationDate, string Genre, string AdditionalDetails,
            int NumberOfPages, string PublishingHouse, double SellingPrice, double BorrowingPrice, string ImagePath, int AuthorId)
        {
            int NewIdBook = 0;
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"insert into Books (Title,ISBN,[Publication Date],Genre,[Additional Details],
             [Numbers Of Pages],[publishing house],[Selling price],
			[borrowing price],Image,[Author Id] )
             Values (@Title,@ISBN,@PublicationDate,@Genre,@AdditionalDetails,@NumberOfPages,@PublishingHouse,@SellingPrice,@BorrowingPrice,@ImagePath,@AuthorId)
                           SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@ISBN", ISBN);
            command.Parameters.AddWithValue("@PublicationDate", PublicationDate);
            command.Parameters.AddWithValue("@Genre", Genre);
            command.Parameters.AddWithValue("@NumberOfPages", NumberOfPages);
            command.Parameters.AddWithValue("@SellingPrice", SellingPrice);
            command.Parameters.AddWithValue("@BorrowingPrice", BorrowingPrice);
            command.Parameters.AddWithValue("@AuthorId", AuthorId);


            if (!string.IsNullOrWhiteSpace(AdditionalDetails))
            {
                command.Parameters.AddWithValue("@AdditionalDetails", AdditionalDetails);

            }
            else
            {
                command.Parameters.AddWithValue("@AdditionalDetails", System.DBNull.Value);
            }

            if (!string.IsNullOrWhiteSpace(PublishingHouse))
            {
                command.Parameters.AddWithValue("@PublishingHouse", PublishingHouse);

            }
            else
            {
                command.Parameters.AddWithValue("@PublishingHouse", System.DBNull.Value);
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
                if (Result != null && int.TryParse(Result.ToString(), out int insertedId))
                {
                    NewIdBook = insertedId;
                }
            }
            catch { }
            finally { connection.Close(); }
            return NewIdBook;
        }

        static public bool Update(int Id, string Title, string ISBN, int PublicationDate, string Genre, string AdditionalDetails,
            int NumberOfPages, string PublishingHouse, double SellingPrice, double BorrowingPrice, string ImagePath, int AuthorId)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"update Books set Title=@Title,ISBN=@ISBN,[Publication Date]=@PublicationDate,Genre=@Genre,[Additional Details]=@AdditionalDetails,
[Numbers Of Pages]=@NumberOfPages,[publishing house]=@PublishingHouse,[Selling price]=@SellingPrice,[borrowing price]=@BorrowingPrice,Image=@ImagePath,[Author Id]=@AuthorId
where Id=@Id";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", Id);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@ISBN", ISBN);
            command.Parameters.AddWithValue("@PublicationDate", PublicationDate);
            command.Parameters.AddWithValue("@Genre", Genre);
            command.Parameters.AddWithValue("@NumberOfPages", NumberOfPages);
            command.Parameters.AddWithValue("@SellingPrice", SellingPrice);
            command.Parameters.AddWithValue("@BorrowingPrice", BorrowingPrice);
            command.Parameters.AddWithValue("@AuthorId", AuthorId);


            if (!string.IsNullOrWhiteSpace(AdditionalDetails))
            {
                command.Parameters.AddWithValue("@AdditionalDetails", AdditionalDetails);

            }
            else
            {
                command.Parameters.AddWithValue("@AdditionalDetails", System.DBNull.Value);
            }

            if (!string.IsNullOrWhiteSpace(PublishingHouse))
            {
                command.Parameters.AddWithValue("@PublishingHouse", PublishingHouse);

            }
            else
            {
                command.Parameters.AddWithValue("@PublishingHouse", System.DBNull.Value);
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

        static public bool Delete(int Id)
        {
            return GenericData.Delete("delete Books where Id=@Id", "@Id", Id);
        }

        static public DataTable All()
        {
            return GenericData.All(" select * from View_Book_Details");
        }

        static public bool GetBookById(int Id, ref string Title, ref string ISBN, ref int PublicationDate, ref string Genre, ref string AdditionalDetails,
           ref int NumberOfPages, ref string PublishingHouse, ref double SellingPrice, ref double BorrowingPrice, ref string ImagePath, ref int AuthorId)
        {
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"select * from Books where [Id] =@Id";

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
                    AuthorId = (int)reader["Author Id"];
                    Title = (string)reader["Title"];
                    ISBN = (string)reader["ISBN"];
                    PublicationDate = (int)reader["Publication Date"];
                    Genre = (string)reader["Genre"];
                    NumberOfPages = (int)reader["Number Of Pages"];

                    SellingPrice = (double)reader["Selling Price"];
                    BorrowingPrice = (double)reader["Selling Price"];
                    PublishingHouse = (string)reader["Borrowing Price"];

                    AdditionalDetails = reader["Additional Details"] != DBNull.Value ? (string)reader["Additional Details"] : string.Empty;
                    ImagePath = reader["Image"] != DBNull.Value ? (string)reader["Image"] : string.Empty;
                    PublishingHouse = reader["Publishing House"] != DBNull.Value ? (string)reader["Publishing House"] : string.Empty;
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

        static public bool IsExistByISBN(int ISBN)
        {
            return GenericData.Exist("select Found=1 from Books where ISBN=@ISBN", "@ISBN", ISBN);
        }
        static public bool IsExist(int Id)
        {
            return GenericData.Exist("select Found=1 from Books where Id=@Id", "@Id", Id);
        }

    }
}
