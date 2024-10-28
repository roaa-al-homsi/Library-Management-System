using LibrarySystemBusiness;
using System;
using System.Windows.Forms;

namespace LibrarySystem.BorrowingReturn
{
    public partial class frmAddUpdateRecord : Form
    {
        private enum Mode { Add, Update };
        private Mode _Mode;
        private int _RecordId;
        private BorrowingRecord _borrowingRecord;
        public frmAddUpdateRecord(int RecordId)
        {
            InitializeComponent();
            _RecordId = RecordId;
            _Mode = (_RecordId == -1) ? Mode.Add : Mode.Update;
        }
        private void _LoadBorrowingRecord()
        {
            if (_Mode == Mode.Add)
            {
                this.Text = "Add Borrowing Record";
                _borrowingRecord = new BorrowingRecord();
                return;
            }
            this.Text = "Update Borrowing Record";
            _borrowingRecord = BorrowingRecord.Find(_RecordId);
            labBorrId.Visible = true;
            txtBorrowingId.Visible = true;
            txtCopyId.Enabled = false;
            txtCustomerId.Enabled = false;
            txtBorrowingId.Text = _borrowingRecord.Id.ToString();
            txtCopyId.Text = _borrowingRecord.CopyId.ToString();
            txtCustomerId.Text = _borrowingRecord.CustomerId.ToString();
            TimePicBorrowingDate.Value = _borrowingRecord.BorrowingDate;
            TimePicDueDate.Value = _borrowingRecord.DueDate;
        }
        private void frmAddUpdateRecord_Load(object sender, EventArgs e)
        {
            _LoadBorrowingRecord();
        }
        private void _FillRecordBeforeSave()
        {
            _borrowingRecord.CopyId = int.Parse(txtCopyId.Text);
            _borrowingRecord.CustomerId = int.Parse(txtCustomerId.Text);
            _borrowingRecord.BorrowingDate = TimePicBorrowingDate.Value;
            _borrowingRecord.DueDate = (_borrowingRecord.BorrowingDate).AddDays(BorrowingRecord.DefaultBorrowDays);
            _borrowingRecord.ActualReturnDate = DateTime.MinValue;
        }
        private void _PrintMessage(string Text, string Caption, MessageBoxIcon icon)
        {
            MessageBox.Show($"{Text}", Caption, MessageBoxButtons.OK, icon);
        }
        private void _CheckFine()
        {
            if (_borrowingRecord.ActualReturnDate > _borrowingRecord.DueDate)
            {
                TimeSpan NumberOfLateDays = (_borrowingRecord.ActualReturnDate) - (_borrowingRecord.DueDate);
                Fine fine = new Fine();
                fine.CustomerId = _borrowingRecord.CustomerId;
                fine.BorrowingRecordId = _borrowingRecord.Id;
                fine.NumberOfLateDays = (byte)NumberOfLateDays.TotalDays;
                fine.Amount = Fine.DefaultFinePerDay * fine.NumberOfLateDays;
                fine.PaymentStatus = false;
                fine.Save();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _FillRecordBeforeSave();
            if (!Customer.Exist(_borrowingRecord.CustomerId))
            {
                _PrintMessage("Failed,There is no customer with this id", "Error", MessageBoxIcon.Error);
                return;
            }
            BookCopy bookCopy = BookCopy.Find(_borrowingRecord.CopyId);
            if (bookCopy == null)
            {
                _PrintMessage("Failed,There is no copy with this id", "Error", MessageBoxIcon.Error);
                return;
            }
            if (bookCopy.AvailabilityStatus == false && _Mode == Mode.Add)
            {
                _PrintMessage("Failed,this copy is not available in this time", "Error", MessageBoxIcon.Error);
                return;
            }
            if (_borrowingRecord.Save())
            {
                TimePicDueDate.Value = (_borrowingRecord.BorrowingDate).AddDays(BorrowingRecord.DefaultBorrowDays);
                labBorrId.Visible = true;
                txtBorrowingId.Visible = true;
                txtBorrowingId.Text = _borrowingRecord.Id.ToString();
                bookCopy.AvailabilityStatus = false;
                bookCopy.Save();
                _PrintMessage("Data Saved Successfully", "Information", MessageBoxIcon.Information);
                _CheckFine();
            }
            else
            {
                _PrintMessage("Failed Operation", "Error", MessageBoxIcon.Error);
                return;
            }
        }
        private void btnViewCustomerInfo_Click(object sender, EventArgs e)
        {
            panelCustomerInfo.Visible = true;
            dgvCustomerInfo.DataSource = Customer.ViewSpecificCustomer(int.Parse(txtCustomerId.Text));
        }
        private void btnViewBorrowingInfo_Click(object sender, EventArgs e)
        {
            PanelBorrowingInfo.Visible = true;
            dgvCopyInfo.DataSource = BookCopy.ViewInfoSpecificCopyBook(int.Parse(txtCopyId.Text));
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

