using LibrarySystemBusiness;
using System;
using System.Windows.Forms;

namespace LibraryStstem.Logins
{
    public partial class ViewLogins : Form
    {
        public ViewLogins()
        {
            InitializeComponent();
        }
        private void _RefreshDataLogin()
        {
            dgvAllLogins.DataSource = Login.All();
        }
        private void ViewLogins_Load(object sender, EventArgs e)
        {
            _RefreshDataLogin();
        }
    }
}
