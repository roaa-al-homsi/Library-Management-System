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
        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            _MainMenuScreen.OpenChildFormAsync(new frmAddOrUpdateAuthor(-1), sender);
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AuthorId = (int)dgvAllAuthors.CurrentRow.Cells[0].Value;
            _MainMenuScreen.OpenChildFormAsync(new frmAddOrUpdateAuthor(AuthorId));
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AuthorId = (int)dgvAllAuthors.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure delete this Author?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (Author.Delete(AuthorId))
                {
                    MessageBox.Show("Delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delete Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            _RefreshAuthorsData();
        }
    }
}
