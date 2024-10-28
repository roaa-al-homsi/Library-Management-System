using LibrarySystemBusiness;
using System;
using System.Windows.Forms;

namespace LibrarySystem.BorrowingReturn
{
    public partial class frmDetailsBorrowing : Form
    {
        private int _CustomerId;
        private int _CopyId;
        private BookCopy _BookCopy;
        public frmDetailsBorrowing(int CustomerId, int CopyId)
        {
            InitializeComponent();
            _CustomerId = CustomerId;
            _CopyId = CopyId;
        }
        private void _LoadDataToForm()
        {
            uc_Customer1.ViewCustomerData(_CustomerId);
            dgvCopyInfo.DataSource = BookCopy.ViewInfoSpecificCopyBook(_CopyId);
        }
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmDetailsBorrowing_Load(object sender, EventArgs e)
        {
            _LoadDataToForm();
        }
    }
}
