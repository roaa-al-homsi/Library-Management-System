using LibrarySystemBusiness;
using System;
using System.Windows.Forms;

namespace LibraryStstem.Books
{
    public partial class frmBookCopies : Form
    {
        private int _BookId;

        public frmBookCopies(int BookId)
        {
            InitializeComponent();
            _BookId = BookId;
        }

        private void _RefreshBookCopiesData()
        {
            dgvBookCopies.DataSource = BookCopy.All();
        }

        private void frmBookCopies_Load(object sender, EventArgs e)
        {
            _RefreshBookCopiesData();
        }
    }
}
