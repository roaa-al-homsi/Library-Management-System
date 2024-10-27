using LibrarySystemBusiness;
using System;
using System.Windows.Forms;

namespace LibraryStstem.BorrowingReturn
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
            txtBorrowingId.Text = _borrowingRecord.Id.ToString();
            txtCopyId.Text = _borrowingRecord.CopyId.ToString();
            txtCustomerId.Text = _borrowingRecord.CustomerId.ToString();
            TimePicBorrowingDate.Value = _borrowingRecord.BorrowingDate;
            TimePicDueDate.Value = _borrowingRecord.DueDate;
            TimePicActualReturn.Value = _borrowingRecord.ActualReturnDate;
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
            _borrowingRecord.DueDate = TimePicDueDate.Value;
            _borrowingRecord.ActualReturnDate = (TimePicActualReturn.Value.Date == new DateTime(2024, 10, 19)) ? DateTime.MinValue : TimePicActualReturn.Value;
        }
        private void _PrintMessage(string Text, string Caption, MessageBoxIcon icon)
        {
            MessageBox.Show($"{Text}", Caption, MessageBoxButtons.OK, icon);
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
            if (bookCopy.AvailabilityStatus == false)
            {
                _PrintMessage("Failed,this copy is not available in this time", "Error", MessageBoxIcon.Error);
                return;
            }
            if (_borrowingRecord.Save())
            {
                bookCopy.AvailabilityStatus = false;
                bookCopy.Save();
                labBorrId.Visible = true;
                txtBorrowingId.Visible = true;
                txtBorrowingId.Text = _borrowingRecord.Id.ToString();
                _PrintMessage("Data Saved Successfully", "Information", MessageBoxIcon.Information);
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

