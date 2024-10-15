using LibrarySystemBusiness;
using System;
using System.Windows.Forms;

namespace LibrarySystem.Books
{
    public partial class frmAllBooks : Form
    {
        private frmMainMenuScreen _frmMainMenu;
        public frmAllBooks(frmMainMenuScreen frmMainMenu)
        {
            InitializeComponent();
            _frmMainMenu = frmMainMenu;
        }

        private void _RefreshBooksData()
        {
            dgvAllBooks.DataSource = Book.All();
        }

        private void frmAllBooks_Load(object sender, EventArgs e)
        {
            _RefreshBooksData();
        }


    }
}
