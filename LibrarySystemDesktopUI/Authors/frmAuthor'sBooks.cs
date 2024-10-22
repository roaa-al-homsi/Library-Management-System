using LibrarySystemBusiness;
using System;
using System.Windows.Forms;

namespace LibraryStstem.Authors
{
    public partial class frmAuthor_sBooks : Form
    {
        private int _AuthorId;
        public frmAuthor_sBooks(int AuthorId)
        {
            InitializeComponent();
            _AuthorId = AuthorId;
        }
        private void _RefreshDataBooks()
        {
            dgvAllBooks.DataSource = Book.GetBooksForSpecificAuthor(_AuthorId);
        }
        private void frmAuthor_sBooks_Load(object sender, EventArgs e)
        {
            _RefreshDataBooks();
        }
    }
}
