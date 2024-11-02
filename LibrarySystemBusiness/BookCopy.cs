﻿using LibrarySystemDataAccess;
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
        public BookCopy()
        {
            this.Book = new Book();
            this.BookId = -1;
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
        {
            this.Id = BookCopyData.Add(this.BookId, this.AvailabilityStatus);
            return (this.Id != -1);
        }
        private bool _Update()
        {
            return BookCopyData.Update(this.Id, this.BookId, this.AvailabilityStatus);
        }
        private bool _ReadyBookCopy()
        {
            if (!BookData.IsExist(this.BookId))
            {
                return false;
            }
            return true;
        }
        public bool Save()
        {
            if (!_ReadyBookCopy())
            {
                return false;
            }
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
        public static DataTable GetCopiesForSpecificBook(int BookId)
        {
            return BookCopyData.GetCopiesForSpecificBook(BookId);
        }
        public static DataTable ViewInfoSpecificCopyBook(int CopyId)
        {
            return BookCopyData.ViewInfoSpecificCopyBook(CopyId);
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
        public static bool UpdateAvailabilityCopy(int CopyId, bool Availability)
        {
            return BookCopyData.UpdateAvailabilityCopy(CopyId, Availability);
        }

    }

}
