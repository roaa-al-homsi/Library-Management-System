using LibrarySystemBusiness;
using System;
using System.Windows.Forms;

namespace LibrarySystem.Books
{
    public partial class frmAllBooksCopies : Form
    {
        public frmAllBooksCopies()
        {
            InitializeComponent();
        }
        private void _RefreshBookCopies()
        {
            dgvAllBooksCopies.DataSource = BookCopy.All();
        }
        private void frmAllBooksCopies_Load(object sender, EventArgs e)
        {
            _RefreshBookCopies();
        }
    }
}
