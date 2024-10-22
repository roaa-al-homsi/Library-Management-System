using LibrarySystemBusiness;
using System.Windows.Forms;

namespace LibraryStstem.Customers
{
    public partial class frmManageCustomers : Form
    {
        public frmManageCustomers()
        {
            InitializeComponent();
        }

        private void _RefreshCustomersData()
        {
            dgvAllCustomers.DataSource = Customer.All();
        }
        private void frmManageCustomers_Load(object sender, System.EventArgs e)
        {
            _RefreshCustomersData();
        }
    }
}
