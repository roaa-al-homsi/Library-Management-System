using LibrarySystem;
using LibrarySystemBusiness;
using System.Windows.Forms;

namespace LibraryStstem.Users
{
    public partial class frmManageUsers : Form
    {
        private frmMainMenuScreen _MainMenuScreen;
        public frmManageUsers(frmMainMenuScreen frmMainMenuScreen)
        {
            InitializeComponent();
            _MainMenuScreen = frmMainMenuScreen;
        }

        private void _RefreshUsersData()
        {
            dgvAllUsers.DataSource = User.All();
        }

        private void frmManageUsers_Load(object sender, System.EventArgs e)
        {
            _RefreshUsersData();
        }
    }
}
