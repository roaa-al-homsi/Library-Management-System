﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace LibrarySystemDataAccess
{
    static public class BookData
    {

        static public int Add(string Title, string ISBN, int PublicationDate, int GenreId, string AdditionalDetails,
            int NumberOfPages, string PublishingHouse, decimal SellingPrice, decimal BorrowingPrice, string ImagePath, int AuthorId, int Quantity)
        {
            int NewIdBook = 0;
            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"insert into Books (Title,ISBN,[Publication Date],[Genre Id],[Additional Details],
             [Numbers Of Pages],[publishing house],[Selling price],
			[borrowing price],Image,[Author Id],Quantity )
             Values (@Title,@ISBN,@PublicationDate,@GenreId,@AdditionalDetails,@NumberOfPages,@PublishingHouse,@SellingPrice,@BorrowingPrice,@ImagePath,@AuthorId,@Quantity)
                           

Declare @BookId int;
Set @BookId = SCOPE_IDENTITY();

WHILE @Quantity > 0
BEGIN
    INSERT INTO BookCopies ([Book Id], [Availability Status])
    VALUES (@BookId, 1);
    
    SET @Quantity = @Quantity - 1;
END;

SELECT SCOPE_IDENTITY();
";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@ISBN", ISBN);
            command.Parameters.AddWithValue("@PublicationDate", PublicationDate);
            command.Parameters.AddWithValue("@GenreId", GenreId);
            command.Parameters.AddWithValue("@NumberOfPages", NumberOfPages);
            command.Parameters.AddWithValue("@SellingPrice", SellingPrice);
            command.Parameters.AddWithValue("@BorrowingPrice", BorrowingPrice);
            command.Parameters.AddWithValue("@AuthorId", AuthorId);
            command.Parameters.AddWithValue("@Quantity", Quantity);

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
        static public bool Update(int Id, string Title, string ISBN, int PublicationDate, int GenreId, string AdditionalDetails,
            int NumberOfPages, string PublishingHouse, decimal SellingPrice, decimal BorrowingPrice, string ImagePath, int AuthorId, int Quantity)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(SettingData.ConnectionString);
            string query = @"

-- Get the previous quantity
    DECLARE @PreviousQuantity INT;
    SELECT @PreviousQuantity = b.Quantity 
    FROM Books b 
    WHERE b.Id = @Id;


UPDATE Books 
    SET Title = @Title,
        ISBN = @ISBN,
        [Publication Date] = @PublicationDate,
        [Genre Id] = @GenreId,
        [Additional Details] = @AdditionalDetails,
        [Numbers Of Pages] = @NumberOfPages,
        [publishing house] = @PublishingHouse,
        [Selling price] = @SellingPrice,
        [borrowing price] = @BorrowingPrice,
        Image = @ImagePath,
        [Author Id] = @AuthorId,
        Quantity = @Quantity
    WHERE Id = @Id;
    

    -- Calculate the difference in quantity
    DECLARE @DiffQuantity INT;
    SET @DiffQuantity = @Quantity - @PreviousQuantity;

    -- Insert copies if the new quantity is higher
    IF (@DiffQuantity > 0)
    BEGIN
        WHILE @DiffQuantity > 0
        BEGIN
            INSERT INTO BookCopies ([Book Id], [Availability Status])
            VALUES (@Id, 1);

            SET @DiffQuantity = @DiffQuantity - 1;
        END;
    END
    ELSE
    BEGIN
        -- Delete excess copies if the new quantity is lower
        DELETE top(ABS(@DiffQuantity)) FROM BookCopies where [Book Id] = @Id;
    END;

";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", Id);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@ISBN", ISBN);
            command.Parameters.AddWithValue("@PublicationDate", PublicationDate);
            command.Parameters.AddWithValue("@GenreId", GenreId);
            command.Parameters.AddWithValue("@NumberOfPages", NumberOfPages);
            command.Parameters.AddWithValue("@SellingPrice", SellingPrice);
            command.Parameters.AddWithValue("@BorrowingPrice", BorrowingPrice);
            command.Parameters.AddWithValue("@AuthorId", AuthorId);
            command.Parameters.AddWithValue("@Quantity", Quantity);

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
            return GenericData.All(" select * from Books");
        }
        static public bool GetBookById(int Id, ref string Title, ref string ISBN, ref int PublicationDate, ref int GenreId, ref string AdditionalDetails,
           ref int NumberOfPages, ref string PublishingHouse, ref decimal SellingPrice, ref decimal BorrowingPrice, ref string ImagePath, ref int AuthorId, ref int Quantity)
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
                    GenreId = (int)reader["Genre Id"];
                    NumberOfPages = (int)reader["Numbers Of Pages"];
                    SellingPrice = (decimal)reader["Selling Price"];
                    BorrowingPrice = (decimal)reader["Borrowing Price"];
                    Quantity = (int)reader["Quantity"];
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
        static public bool IsExistByISBN(string ISBN)
        {
            return GenericData.Exist("select Found=1 from Books where ISBN=@ISBN", "@ISBN", ISBN);
        }
        static public bool IsExist(int Id)
        {
            return GenericData.Exist("select Found=1 from Books where Id=@Id", "@Id", Id);
        }
        static public bool IsExistBookByAuthorId(int AuthorId)
        {
            return GenericData.Exist("select Found=1 from Books where [Author Id]=@AuthorId", "@AuthorId", AuthorId);
        }
        static public bool ExistBookByGenreId(int GenreId)
        {
            return GenericData.Exist("select Found=1 from Books where [Genre Id]=@GenreId", "@GenreId", GenreId);
        }
        static public DataTable GetBooksForSpecificAuthor(int AuthorId)
        {
            return GenericData.ShowDataForSpecificObject("select * from Books where [Author Id]=@AuthorId", "@AuthorId", AuthorId);
        }
        static public DataTable GetBooksForSpecificGenre(int GenreId)
        {
            return GenericData.ShowDataForSpecificObject("select * from Books where [Genre Id]=@GenreId", "@GenreId", GenreId);
        }
    }
}
