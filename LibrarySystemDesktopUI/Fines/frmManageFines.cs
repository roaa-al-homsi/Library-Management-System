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
    }
}
