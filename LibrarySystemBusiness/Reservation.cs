﻿using LibrarySystemDataAccess;
using System;
using System.Data;

namespace LibrarySystemBusiness
{
    public class Reservation
    {
        private enum Mode { Add, Update };
        private Mode _Mode;

        public Customer Customer { get; private set; }
        public int CustomerId { get; set; }
        public BookCopy BookCopy { get; private set; }
        public int CopyId { get; set; }
        public int Id { get; set; }
        public DateTime ReservationDate { get; set; }
        public Reservation(int CustomerId, int CopyId)
        {
            this.Customer = Customer.Find(CustomerId);
            if (this.Customer != null)
            {
                this.CustomerId = CustomerId;
            }
            this.BookCopy = BookCopy.Find(CopyId);
            if (this.BookCopy != null)
            {
                this.CopyId = CopyId;
            }
            this.Id = -1;
            this.ReservationDate = DateTime.MinValue;
            _Mode = Mode.Add;
        }
        private Reservation(int Id, int CustomerId, int CopyId, DateTime ReservationDate)
        {
            this.Customer = Customer.Find(CustomerId);
            if (this.Customer != null)
            {
                this.CustomerId = CustomerId;
            }
            this.BookCopy = BookCopy.Find(CopyId);
            if (this.BookCopy != null)
            {
                this.CopyId = CopyId;
            }
            this.Id = Id;
            this.ReservationDate = ReservationDate;
            _Mode = Mode.Update;
        }

        private bool _Add()
        {//validation
            this.Id = ReservationData.Add(this.CustomerId, this.CopyId, this.ReservationDate);
            return (this.Id != -1);
        }
        private bool _Update()
        {//validation
            return ReservationData.Update(this.Id, this.CustomerId, this.CopyId, this.ReservationDate);
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
            return ReservationData.Delete(Id);
        }
        public static DataTable All()
        {
            return ReservationData.All();
        }
        public static bool Exist(int Id)
        {
            return ReservationData.Exist(Id);
        }
        public static Reservation Find(int Id)
        {
            int CustomerId = -1;
            int CopyId = -1;
            DateTime ReservationDate = DateTime.MinValue;

            if (ReservationData.GetReservationRecordById(Id, ref CustomerId, ref CopyId, ref ReservationDate))
            {
                return new Reservation(Id, CustomerId, CopyId, ReservationDate);
            }
            return null;
        }

    }
}
