using LibrarySystemDataAccess;
using System;
using System.Configuration;
using System.Data;

namespace LibrarySystemBusiness
{
    public class Fine
    {
        public static readonly byte DefaultFinePerDay = Convert.ToByte(ConfigurationManager.AppSettings["DefaultFinePerDay"]);
        private enum Mode { Add, Update }
        private Mode _Mode;
        public Customer Customer { get; private set; }//composition 
        public int CustomerId { get; set; }//Fk
        public BorrowingRecord BorrowingRecord { get; private set; }//composition 
        public int BorrowingRecordId { get; set; }//Fk
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public byte NumberOfLateDays { get; set; }
        public bool PaymentStatus { get; set; }

        public Fine()
        {
            this.Customer = new Customer();
            this.BorrowingRecord = new BorrowingRecord();
            this.CustomerId = -1;
            this.BorrowingRecordId = -1;
            this.Id = -1;
            this.Amount = 1;
            this.NumberOfLateDays = 1;
            this.PaymentStatus = false;
            _Mode = Mode.Add;
        }
        private Fine(int Id, int CustomerId, int BorrowingRecordId, decimal Amount, byte NumberOfLateDays, bool PaymentStatus)
        {
            this.Id = Id;
            this.CustomerId = CustomerId;
            this.BorrowingRecordId = BorrowingRecordId;
            this.Amount = Amount;
            this.NumberOfLateDays = NumberOfLateDays;
            this.PaymentStatus = PaymentStatus;
            this.Customer = Customer.Find(CustomerId);
            this.BorrowingRecord = BorrowingRecord.Find(BorrowingRecordId);
            _Mode = Mode.Update;
        }
        private bool _Add()
        {
            this.Id = FineData.Add(this.CustomerId, this.BorrowingRecordId, this.Amount, this.NumberOfLateDays, this.PaymentStatus);
            return (this.Id != -1);
        }
        private bool _Update()
        {
            return FineData.Update(this.Id, this.CustomerId, this.BorrowingRecordId, this.Amount, this.NumberOfLateDays, this.PaymentStatus);
        }
        private bool _ReadyFine()
        {
            if (!CustomerData.Exist(this.CustomerId) || !BorrowingRecordData.Exist(this.BorrowingRecordId))
            {
                return false;
            }
            if (this.Amount == 0 || this.NumberOfLateDays == 0)
            {
                return false;
            }
            return true;
        }
        public bool Save()
        {
            if (!_ReadyFine())
            { return false; }
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
            return FineData.Delete(Id);
        }
        public static DataTable All()
        {
            return FineData.All();
        }
        public static bool Exist(int Id)
        {
            return FineData.Exist(Id);
        }
        public static bool ExistByCustomerId(int CustomerId)
        {
            return FineData.ExistFineByCustomerId(CustomerId);
        }
        public static Fine Find(int Id)
        {
            int BorrowingRecordId = -1;
            int CustomerId = -1;
            decimal Amount = 1;
            byte NumberOfLateDays = 0;
            bool PaymentStatus = false;
            if (FineData.GetFineById(Id, ref CustomerId, ref BorrowingRecordId, ref Amount, ref NumberOfLateDays, ref PaymentStatus))
            {
                return new Fine(Id, CustomerId, BorrowingRecordId, Amount, NumberOfLateDays, PaymentStatus);
            }
            return null;
        }
    }
}
