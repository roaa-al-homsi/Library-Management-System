using LibrarySystemDataAccess;
using System;
using System.Data;
namespace LibrarySystemBusiness
{
    public class BorrowingRecord
    {
        private enum Mode { Add, Update };
        private Mode _Mode;

        public BookCopy BookCopy { get; private set; }//composition 
        public int CopyId { get; set; }//FK
        public Customer Customer { get; private set; }//composition 
        public int CustomerId { get; set; }//FK

        public int Id { get; set; }
        public DateTime BorrowingDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ActualReturnDate { get; set; }

        public BorrowingRecord()
        {
            this.BookCopy = new BookCopy();
            this.Customer = new Customer();
            this.CopyId = -1;
            this.CustomerId = -1;
            this.BorrowingDate = DateTime.MinValue;
            this.DueDate = DateTime.MinValue;
            this.ActualReturnDate = DateTime.MinValue;
            this.Id = -1;
            _Mode = Mode.Add;
        }
        private BorrowingRecord(int Id, int BookCopyId, int CustomerId, DateTime BorrowingDate, DateTime DueDate, DateTime ActualReturnDate)
        {
            this.Customer = Customer.Find(CustomerId);
            this.BookCopy = BookCopy.Find(BookCopyId);
            this.Id = Id;
            this.BorrowingDate = BorrowingDate;
            this.DueDate = DueDate;
            this.ActualReturnDate = ActualReturnDate;
            this.CopyId = BookCopyId;
            this.CustomerId = CustomerId;
            _Mode = Mode.Update;
        }
        private bool _Add()
        {//validation
            this.Id = BorrowingRecordData.Add(this.CopyId, this.CustomerId, this.BorrowingDate, this.DueDate, this.ActualReturnDate);
            return (this.Id != -1);
        }
        private bool _Update()
        {
            return BorrowingRecordData.Update(this.Id, this.CopyId, this.CustomerId, this.BorrowingDate, this.DueDate, this.ActualReturnDate);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case Mode.Add:
                    return _Add();
                case Mode.Update:
                    return _Update();
                default: return false;
            }
        }
        public static bool Delete(int Id)
        {
            return BorrowingRecordData.Delete(Id);
        }
        public static DataTable All()
        {
            return BorrowingRecordData.All();
        }
        public static BorrowingRecord Find(int Id)
        {
            int CopyId = -1;
            int CustomerId = -1;
            DateTime BorrowingDate = DateTime.MinValue;
            DateTime DueDate = DateTime.MinValue;
            DateTime ActualReturnDate = DateTime.MinValue;
            if (BorrowingRecordData.GetBorrowingRecordById(Id, ref CopyId, ref CustomerId, ref BorrowingDate, ref DueDate, ref ActualReturnDate))
            {
                return new BorrowingRecord(Id, CopyId, CustomerId, BorrowingDate, DueDate, ActualReturnDate);
            }
            return null;
        }
        public static bool Exist(int Id)
        {
            return BorrowingRecordData.Exist(Id);
        }
    }
}
