using LibrarySystem;
using LibrarySystemBusiness;
using System;
using System.Windows.Forms;

namespace LibrarySystem.BorrowingReturn
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
        private void _CheckFine(BorrowingRecord borrowingRecord)
        {
            if (borrowingRecord.ActualReturnDate > borrowingRecord.DueDate)
            {
                TimeSpan NumberOfLateDays = (borrowingRecord.ActualReturnDate) - (borrowingRecord.DueDate);
                Fine fine = new Fine();
                fine.CustomerId = borrowingRecord.CustomerId;
                fine.BorrowingRecordId = borrowingRecord.Id;
                fine.NumberOfLateDays = (byte)NumberOfLateDays.TotalDays;
                fine.Amount = Fine.DefaultFinePerDay * fine.NumberOfLateDays;
                fine.PaymentStatus = false;
                fine.Save();
            }
        }
        private void _ChangeAvailabilityCopy(int CopyId)
        {
            BookCopy bookCopy = BookCopy.Find(CopyId);
            if (bookCopy != null)
            {
                bookCopy.AvailabilityStatus = true;
                bookCopy.Save();
            }
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
                    //borrowingRecord.BookCopy.AvailabilityStatus = true;
                }
                if (borrowingRecord.Save())
                {
                    MessageBox.Show("The return process was completed successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                _RefreshBorrowingData();
                _CheckFine(borrowingRecord);
                _ChangeAvailabilityCopy(borrowingRecord.CopyId);
            }
            else
            {
                return;
            }
        }
        private void ItemUpdate_Click(object sender, EventArgs e)
        {
            int RecordId = (int)dgvAllBorrowingRecords.CurrentRow.Cells[0].Value;
            _frmMainMenu.OpenChildFormAsync(new frmAddUpdateRecord(RecordId));
        }

        private void ItemViewDetails_Click(object sender, EventArgs e)
        {
            int CustomerId = (int)dgvAllBorrowingRecords.CurrentRow.Cells[2].Value;
            int CopyId = (int)dgvAllBorrowingRecords.CurrentRow.Cells[1].Value;
            frmDetailsBorrowing frmDetailsBorrowing = new frmDetailsBorrowing(CustomerId, CopyId);
            frmDetailsBorrowing.ShowDialog();
        }
    }

}
