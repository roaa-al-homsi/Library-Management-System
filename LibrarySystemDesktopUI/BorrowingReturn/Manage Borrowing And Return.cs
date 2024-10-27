using LibrarySystem;
using LibrarySystemBusiness;
using System;
using System.Windows.Forms;

namespace LibraryStstem.BorrowingReturn
{
    public partial class frmManageBorrowing : Form
    {
        private frmMainMenuScreen _frmMainMenu;
        public frmManageBorrowing(frmMainMenuScreen frmMainMenuScreen)
        {
            InitializeComponent();
            _frmMainMenu = frmMainMenuScreen;
        }
        private void _RefreshBorrowingData()
        {
            dgvAllBorrowingRecords.DataSource = BorrowingRecord.All();
        }
        private void frmManageBorrowing_Load(object sender, EventArgs e)
        {
            _RefreshBorrowingData();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            _frmMainMenu.OpenChildFormAsync(new frmAddUpdateRecord(-1));
        }
    }
}
