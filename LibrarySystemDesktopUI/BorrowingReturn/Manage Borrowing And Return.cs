using LibrarySystemBusiness;
using System;
using System.Windows.Forms;

namespace LibraryStstem.BorrowingReturn
{
    public partial class frmManageBorrowing : Form
    {
        public frmManageBorrowing()
        {
            InitializeComponent();
        }
        private void _RefreshBorrowingData()
        {
            dgvAllBorrowingRecords.DataSource = BorrowingRecord.All();
        }
        private void frmManageBorrowing_Load(object sender, EventArgs e)
        {
            _RefreshBorrowingData();
        }
    }
}
