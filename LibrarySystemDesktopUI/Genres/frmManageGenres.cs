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
    }
}
