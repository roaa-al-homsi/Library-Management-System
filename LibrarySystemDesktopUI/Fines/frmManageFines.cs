using LibrarySystemBusiness;
using System.Windows.Forms;
namespace LibraryStstem.Fines
{
    public partial class frmManageFines : Form
    {
        public frmManageFines()
        {
            InitializeComponent();
        }
        private void _RefreshFinesData()
        {
            dgvAllFines.DataSource = Fine.All();
        }
        private void frmManageFines_Load(object sender, System.EventArgs e)
        {
            _RefreshFinesData();
        }
        private void ItemPay_Click(object sender, System.EventArgs e)
        {
            int FineId = (int)dgvAllFines.CurrentRow.Cells[0].Value;
            Fine fine = Fine.Find(FineId);
            if (fine != null)
            {
                fine.PaymentStatus = true;
                if (fine.Save())
                {
                    MessageBox.Show($"{fine.Amount} Payment has been made successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            _RefreshFinesData();
        }
        private void cmsManageFines_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool IsPaid = (bool)dgvAllFines.CurrentRow.Cells[5].Value;
            ItemPay.Visible = (!IsPaid);
        }
    }
}
