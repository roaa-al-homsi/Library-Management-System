﻿using LibrarySystemBusiness;
using System.Windows.Forms;

namespace LibraryStstem
{
    public partial class uc_Customer : UserControl
    {
        public uc_Customer()
        {
            InitializeComponent();
        }
        public void ViewCustomerData(int CustomerId)
        {
            Customer _customer = Customer.Find(CustomerId);
            if (_customer != null)
            {
                txtCardNum.Text = _customer.LibraryCardNumber;
                labCustId.Text = _customer.Id.ToString();
                uc_PersonInfo2.ShowDataPerson(_customer.Person);
                uc_PersonInfo2.BirthDateStatus = false;
            }
        }
    }
}
