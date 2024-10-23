﻿using LibrarySystem;
using LibrarySystemBusiness;
using System.Windows.Forms;

namespace LibraryStstem.Customers
{
    public partial class frmManageCustomers : Form
    {
        private frmMainMenuScreen _mainMenuScreen;
        public frmManageCustomers(frmMainMenuScreen MainMenuScreen)
        {
            InitializeComponent();
            _mainMenuScreen = MainMenuScreen;
        }

        private void _RefreshCustomersData()
        {
            dgvAllCustomers.DataSource = Customer.All();
        }
        private void frmManageCustomers_Load(object sender, System.EventArgs e)
        {
            _RefreshCustomersData();
        }

        private void btnAddCustomer_Click(object sender, System.EventArgs e)
        {
            _mainMenuScreen.OpenChildFormAsync(new frmAddOrUpdateCustomer(-1));
        }
    }
}
