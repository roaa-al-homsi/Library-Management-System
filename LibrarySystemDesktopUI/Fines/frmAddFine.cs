using LibrarySystemBusiness;
using System.Windows.Forms;

namespace LibraryStstem.Fines
{
    public partial class frmAddFine : Form
    {
        private Fine _Fine = new Fine();
        public frmAddFine()
        {
            InitializeComponent();
        }

        private void _FillFineBeforeSave()
        {
            _Fine.CustomerId = int.Parse(txtCustomerId.Text);
            _Fine.BorrowingRecordId = int.Parse(txtBorrowingId.Text);
            _Fine.NumberOfLateDays = byte.Parse(txtNumberOfLate.Text);
            _Fine.PaymentStatus = (cbPayment.Text == "paid") ? true : false;
            _Fine.Amount = _Fine.NumberOfLateDays * Fine.DefaultFinePerDay;
        }
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            _FillFineBeforeSave();
            if (_Fine.Save())
            {
                MessageBox.Show("Data Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Failed Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtBoxNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnViewCustomerInfo_Click(object sender, System.EventArgs e)
        {
            if (!Customer.Exist(int.Parse(txtCustomerId.Text)))
            {
                MessageBox.Show("There is no Customer with this id ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerId.Text = string.Empty;
            }
            else
            {
                panelCustomerInfo.Visible = true;
                dgvCustomerInfo.DataSource = Customer.ViewSpecificCustomer(int.Parse(txtCustomerId.Text));
            }

        }
        private void btnViewBorrowingInfo_Click(object sender, System.EventArgs e)
        {
            if (!BorrowingRecord.Exist(int.Parse(txtBorrowingId.Text)))
            {
                MessageBox.Show("There is no borrowing record with this id ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBorrowingId.Text = string.Empty;
            }
            else
            {
                PanelBorrowingInfo.Visible = true;
                dgvBorrowingInfo.DataSource = BorrowingRecord.ViewSpecificBorrowingRecord(int.Parse(txtBorrowingId.Text));
            }
        }
        private void txtNumberOfLate_TextChanged(object sender, System.EventArgs e)
        {
            labAmount.Visible = true;
            txtAmount.Visible = true;
            txtAmount.Text = (short.Parse(txtNumberOfLate.Text) * Fine.DefaultFinePerDay).ToString();
        }
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}

