using LibrarySystemBusiness;
using System;
using System.Windows.Forms;

namespace LibrarySystem.Books
{
    public partial class frmBookCopies : Form
    {
        private int _BookId;
        private string _NameBook;
        public frmBookCopies(int BookId, string NameBook)
        {
            InitializeComponent();
            _BookId = BookId;
            _NameBook = NameBook;
        }
        private void _RefreshBookCopiesData()
        {
            dgvBookCopies.DataSource = BookCopy.GetCopiesForSpecificBook(_BookId);
        }
        private void frmBookCopies_Load(object sender, EventArgs e)
        {
            _RefreshBookCopiesData();
            labNameBook.Text = _NameBook;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
