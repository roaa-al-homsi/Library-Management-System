using LibrarySystem;
using LibrarySystemBusiness;
using System;
using System.Windows.Forms;

namespace LibraryStstem.Authors
{
    public partial class frmManageAuthors : Form
    {
        private frmMainMenuScreen _MainMenuScreen;
        public frmManageAuthors(frmMainMenuScreen MainMenuScreen)
        {
            InitializeComponent();
            _MainMenuScreen = MainMenuScreen;
        }
        private void _RefreshAuthorsData()
        {
            dgvAllAuthors.DataSource = Author.All();
        }

        private void frmManageAuthors_Load(object sender, EventArgs e)
        {
            _RefreshAuthorsData();
        }
    }
}
