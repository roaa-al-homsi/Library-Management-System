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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure delete this Book?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                int BookId = (int)dgvAllBooks.CurrentRow.Cells[0].Value;

                if (Book.Delete(BookId))
                {
                    MessageBox.Show("Delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delete Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                _RefreshBooksData();
            }
        }
    }
}
