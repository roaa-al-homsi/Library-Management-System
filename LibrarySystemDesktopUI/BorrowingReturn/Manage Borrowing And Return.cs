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
        private void cmsManageBorrowingRecord_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ItemReturn.Visible = (dgvAllBorrowingRecords.CurrentRow.Cells[5].Value == System.DBNull.Value);
        }
        private void ItemReturn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want return this copy?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int RecordId = (int)dgvAllBorrowingRecords.CurrentRow.Cells[0].Value;
                BorrowingRecord borrowingRecord = BorrowingRecord.Find(RecordId);
                if (borrowingRecord != null)
                {
                    borrowingRecord.ActualReturnDate = DateTime.Now;
                }
                if (borrowingRecord.Save())
                {
                    MessageBox.Show("The return process was completed successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                _RefreshBorrowingData();
            }
            else
            {
                return;
            }
        }
    }

}
