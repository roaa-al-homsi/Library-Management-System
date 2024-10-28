using LibrarySystemBusiness;
using System;
using System.Windows.Forms;

namespace LibrarySystem.Fines
{
    public partial class frmDetailsFines : Form
    {
        private int _CustomerId;
        private int _BorrowingId;
        private BorrowingRecord _borrowingRecord;
        public frmDetailsFines(int CustomerId, int BorrowingId)
        {
            InitializeComponent();
            _CustomerId = CustomerId;
            _BorrowingId = BorrowingId;
        }
        private void _LoadDetailsFineData()
        {
            uc_Customer1.ViewCustomerData(_CustomerId);
            _borrowingRecord = BorrowingRecord.Find(_BorrowingId);
            if (_borrowingRecord != null)
            {
                txtBorrowingId.Text = _borrowingRecord.Id.ToString();
                TimePicActualReturn.Value = _borrowingRecord.ActualReturnDate;
                TimePicBorrowingDate.Value = _borrowingRecord.BorrowingDate;
                TimePicDueDate.Value = _borrowingRecord.DueDate;
            }
        }
        private void frmDetailsFinescs_Load(object sender, EventArgs e)
        {
            _LoadDetailsFineData();
        }
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
