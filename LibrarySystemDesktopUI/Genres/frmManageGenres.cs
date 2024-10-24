using LibrarySystem;
using LibrarySystemBusiness;
using System.Windows.Forms;

namespace LibraryStstem.Genres
{
    public partial class frmManageGenres : Form
    {
        private frmMainMenuScreen _frmMainMenuScreen;
        public frmManageGenres(frmMainMenuScreen frmMainMenuScreen)
        {
            InitializeComponent();
            _frmMainMenuScreen = frmMainMenuScreen;
        }

        private void _RefreshGenresData()
        {
            dgvAllGeners.DataSource = Genre.All();
        }

        private void frmManageGenres_Load(object sender, System.EventArgs e)
        {
            _RefreshGenresData();
        }

        private void btnAddGenre_Click(object sender, System.EventArgs e)
        {
            frmAddUpdateGenre frmAddUpdate = new frmAddUpdateGenre(-1);
            frmAddUpdate.ShowDialog();
            _RefreshGenresData();
        }

        private void ItemUpdate_Click(object sender, System.EventArgs e)
        {
            int GenreId = (int)dgvAllGeners.CurrentRow.Cells[0].Value;
            frmAddUpdateGenre frmAddUpdate = new frmAddUpdateGenre(GenreId);
            frmAddUpdate.ShowDialog();
            _RefreshGenresData();
        }

        private void ItemDelete_Click(object sender, System.EventArgs e)
        {
            int GenreId = (int)dgvAllGeners.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure delete this Genre?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (Genre.Delete(GenreId))
                {
                    MessageBox.Show("Delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delete Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            _RefreshGenresData();
        }
    }
}
