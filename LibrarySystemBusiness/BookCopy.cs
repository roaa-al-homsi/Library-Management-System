using LibrarySystemDataAccess;
using System.Data;

namespace LibrarySystemBusiness
{
    public class BookCopy
    {
        private enum Mode { Add, Update };
        private Mode _Mode;
        public Book Book { get; private set; }
        public int Id { get; set; }
        public int BookId { get; set; }
        public bool AvailabilityStatus { get; set; }
        public BookCopy(int BookId)
        {
            this.Book = Book.Find(BookId);
            this.BookId = BookId;
            this.AvailabilityStatus = false;
            this.Id = -1;
            _Mode = Mode.Add;
        }
        private BookCopy(int Id, int BookId, bool AvailabilityStatus)
        {
            this.Book = Book.Find(BookId);
            this.Id = Id;
            this.BookId = BookId;
            this.AvailabilityStatus = AvailabilityStatus;

            _Mode = Mode.Update;
        }
        private bool _Add()
        {//validation
            this.Id = BookCopyData.Add(this.BookId, this.AvailabilityStatus);
            return (this.Id != -1);
        }
        private bool _Update()
        {
            //validation
            return BookCopyData.Update(this.Id, this.BookId, this.AvailabilityStatus);
        }
        public bool Save()
        {
            switch (this._Mode)
            {
                case Mode.Add: return _Add();
                case Mode.Update: return _Update();
                default: return false;
            }
        }
        public static bool Delete(int Id)
        {
            return BookCopyData.Delete(Id);
        }
        public static DataTable All()
        {
            return BookCopyData.All();
        }
        public static bool Exist(int Id)
        {
            return BookCopyData.Exist(Id);
        }
        public static BookCopy Find(int Id)
        {
            int BookId = -1;
            bool AvailabilityStatus = false;
            if (BookCopyData.GetBookCopy(Id, ref BookId, ref AvailabilityStatus))
            {
                return new BookCopy(Id, BookId, AvailabilityStatus);
            }
            return null;
        }

    }

}
