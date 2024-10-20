using LibrarySystemDataAccess;
using System.Data;

namespace LibrarySystemBusiness
{
    public class Book
    {
        private enum Mode { Add, Update };
        private Mode _Mode;
        public Author Author { get; private set; }//FK Composition
        public int AuthorId { get; set; }
        public Genre Genre { get; private set; }//FK Composition
        public int GenreId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int PublicationDate { get; set; }
        public string AdditionalDetails { get; set; }
        public int NumberOfPages { get; set; }
        public string PublishingHouse { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal BorrowingPrice { get; set; }
        public string ImagePath { get; set; }


        public Book()
        {
            this.Author = new Author();
            this.AuthorId = -1;
            this.Genre = new Genre();
            this.GenreId = -1;
            this.Id = -1;
            this.Title = string.Empty;
            this.ISBN = string.Empty;
            this.PublicationDate = 0;
            this.AdditionalDetails = string.Empty;
            this.NumberOfPages = 0;
            this.BorrowingPrice = 0;
            this.ImagePath = string.Empty;
            this.SellingPrice = 0;

            _Mode = Mode.Add;
        }

        private Book(int Id, string Title, string ISBN, int PublicationDate, int GenreId, string AdditionalDetails,
            int NumberOfPages, string PublishingHouse, decimal SellingPrice, decimal BorrowingPrice, string ImagePath, int AuthorId)
        {
            this.Author = Author.Find(AuthorId);
            this.AuthorId = AuthorId;
            this.Genre = Genre.Find(GenreId);
            this.GenreId = GenreId;
            this.Id = Id;
            this.Title = Title;
            this.ISBN = ISBN;
            this.PublicationDate = PublicationDate;
            this.AdditionalDetails = AdditionalDetails;
            this.NumberOfPages = NumberOfPages;
            this.BorrowingPrice = BorrowingPrice;
            this.ImagePath = ImagePath;
            this.SellingPrice = SellingPrice;

            _Mode = Mode.Update;
        }
        private bool _Add()
        {
            this.Id = BookData.Add(this.Title, this.ISBN, this.PublicationDate, this.GenreId, this.AdditionalDetails, this.NumberOfPages, this.PublishingHouse, this.SellingPrice, this.BorrowingPrice, this.ImagePath, this.AuthorId);
            return (this.Id != -1);
        }
        private bool _Update()
        {
            return BookData.Update(this.Id, this.Title, this.ISBN, this.PublicationDate, this.GenreId, this.AdditionalDetails, this.NumberOfPages, this.PublishingHouse, this.SellingPrice, this.BorrowingPrice, this.ImagePath, this.AuthorId);
        }
        public bool Save()
        {
            switch (this._Mode)
            {
                case Mode.Add:
                    return _Add();
                case Mode.Update:
                    return _Update();
            }
            return false;
        }
        static public Book Find(int Id)
        {
            string Title = string.Empty;
            string ISBN = string.Empty;
            int PublicationDate = 1;
            int GenreId = -1;
            string AdditionalDetails = string.Empty;
            int NumberOfPages = 0;
            string PublishingHouse = string.Empty;
            decimal SellingPrice = 0;
            decimal BorrowingPrice = 0;
            string ImagePath = string.Empty;
            int AuthorId = -1;

            if (BookData.GetBookById(Id, ref Title, ref ISBN, ref PublicationDate, ref GenreId, ref AdditionalDetails, ref NumberOfPages, ref PublishingHouse, ref SellingPrice, ref BorrowingPrice
                , ref ImagePath, ref AuthorId))
            {
                return new Book(Id, Title, ISBN, PublicationDate, GenreId, AdditionalDetails, NumberOfPages, PublishingHouse, SellingPrice, BorrowingPrice, ImagePath, AuthorId);
            }
            return null;
        }
        static public bool ExistByISBN(int ISBN)
        {
            return BookData.IsExistByISBN(ISBN);
        }
        static public bool Exist(int Id)
        {
            return BookData.IsExist(Id);
        }
        static public bool Delete(int Id)
        {
            return BookData.Delete(Id);
        }
        static public DataTable All()
        {
            return BookData.All();
        }
    }
}

