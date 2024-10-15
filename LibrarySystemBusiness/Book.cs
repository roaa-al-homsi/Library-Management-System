using LibrarySystemDataAccess;
using System.Data;

namespace LibrarySystemBusiness
{
    public class Book
    {
        private enum Mode { Add, Update };
        private Mode _Mode;
        public Author Author { get; private set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int PublicationDate { get; set; }
        public string Genre { get; set; }
        public string AdditionalDetails { get; set; }
        public int NumberOfPages { get; set; }
        public string PublishingHouse { get; set; }
        public double SellingPrice { get; set; }
        public double BorrowingPrice { get; set; }
        public string ImagePath { get; set; }
        public int AuthorId { get; set; }

        public Book()
        {
            this.Author = new Author();
            this.AuthorId = -1;
            this.Id = -1;
            this.Title = string.Empty;
            this.ISBN = string.Empty;
            this.PublicationDate = 0;
            this.Genre = string.Empty;
            this.AdditionalDetails = string.Empty;
            this.NumberOfPages = 0;
            this.Genre = string.Empty;
            this.BorrowingPrice = 0;
            this.ImagePath = string.Empty;
            this.SellingPrice = 0;

            _Mode = Mode.Add;
        }

        private Book(int Id, string Title, string ISBN, int PublicationDate, string Genre, string AdditionalDetails,
            int NumberOfPages, string PublishingHouse, double SellingPrice, double BorrowingPrice, string ImagePath, int AuthorId)
        {
            this.Author = Author.Find(AuthorId);
            this.AuthorId = AuthorId;
            this.Id = Id;
            this.Title = Title;
            this.ISBN = ISBN;
            this.PublicationDate = PublicationDate;
            this.Genre = Genre;
            this.AdditionalDetails = AdditionalDetails;
            this.NumberOfPages = NumberOfPages;
            this.Genre = Genre;
            this.BorrowingPrice = BorrowingPrice;
            this.ImagePath = ImagePath;
            this.SellingPrice = SellingPrice;

            _Mode = Mode.Update;
        }
        private bool _Add()
        {
            this.Id = BookData.Add(this.Title, this.ISBN, this.PublicationDate, this.Genre, this.AdditionalDetails, this.NumberOfPages, this.PublishingHouse, this.SellingPrice, this.BorrowingPrice, this.ImagePath, this.AuthorId);
            return (this.Id != -1);
        }
        private bool _Update()
        {
            return BookData.Update(this.Id, this.Title, this.ISBN, this.PublicationDate, this.Genre, this.AdditionalDetails, this.NumberOfPages, this.PublishingHouse, this.SellingPrice, this.BorrowingPrice, this.ImagePath, this.AuthorId);
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
            string Genre = string.Empty;
            string AdditionalDetails = string.Empty;
            int NumberOfPages = 0;
            string PublishingHouse = string.Empty;
            double SellingPrice = 0;
            double BorrowingPrice = 0;
            string ImagePath = string.Empty;
            int AuthorId = -1;

            if (BookData.GetBookById(Id, ref Title, ref ISBN, ref PublicationDate, ref Genre, ref AdditionalDetails, ref NumberOfPages, ref PublishingHouse, ref SellingPrice, ref BorrowingPrice
                , ref ImagePath, ref AuthorId))
            {
                return new Book(Id, Title, ISBN, PublicationDate, Genre, AdditionalDetails, NumberOfPages, PublishingHouse, SellingPrice, BorrowingPrice, ImagePath, AuthorId);
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

