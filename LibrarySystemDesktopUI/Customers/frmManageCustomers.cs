using LibrarySystem;
using LibrarySystemBusiness;
using System.Windows.Forms;

namespace LibraryStstem.Customers
{
    public partial class frmManageCustomers : Form
    {
        private frmMainMenuScreen _mainMenuScreen;
        public frmManageCustomers(frmMainMenuScreen MainMenuScreen)
        {
            InitializeComponent();
            _mainMenuScreen = MainMenuScreen;
        }

        private void _RefreshCustomersData()
        {
            dgvAllCustomers.DataSource = Customer.All();
        }
        private void frmManageCustomers_Load(object sender, System.EventArgs e)
        {
            _RefreshCustomersData();
        }

        private void btnAddCustomer_Click(object sender, System.EventArgs e)
        {
            _mainMenuScreen.OpenChildFormAsync(new frmAddOrUpdateCustomer(-1));
        }

        private void ItemUpdate_Click(object sender, System.EventArgs e)
        {
            int CustomerId = (int)dgvAllCustomers.CurrentRow.Cells[0].Value;
            _mainMenuScreen.OpenChildFormAsync(new frmAddOrUpdateCustomer(CustomerId));
        }

        private void ItemDelete_Click(object sender, System.EventArgs e)
        {
            int CustomerId = (int)dgvAllCustomers.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure delete this Customer?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (Customer.Delete(CustomerId))
                {
                    MessageBox.Show("Delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delete Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            _RefreshCustomersData();
        }
    }
}
