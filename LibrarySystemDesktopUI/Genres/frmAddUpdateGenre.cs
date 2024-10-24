using LibrarySystemBusiness;
using System.Windows.Forms;

namespace LibraryStstem.Genres
{
    public partial class frmAddUpdateGenre : Form
    {
        private enum Mode { Add, Update };
        private Mode _Mode;
        private Genre _Genre;
        private int _GenreId;
        public frmAddUpdateGenre(int genreId)
        {
            InitializeComponent();
            _GenreId = genreId;
            _Mode = (_GenreId == -1) ? Mode.Add : Mode.Update;
        }
        private void _LoadGenreData()
        {
            if (_Mode == Mode.Add)
            {
                _Genre = new Genre();
                this.Text = "Add Genre";
                return;
            }
            _Genre = Genre.Find(_GenreId);
            this.Text = "Update Genre";
            txtNameGenre.Text = _Genre.Name;
            labGenre.Visible = true;
            labGenreId.Visible = true;
            labGenreId.Text = _Genre.Id.ToString();
        }
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            _Genre.Name = txtNameGenre.Text;
            if (_Genre.Save())
            {
                labGenre.Visible = true;
                labGenreId.Visible = true;
                labGenreId.Text = _Genre.Id.ToString();
                MessageBox.Show("Data Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void frmAddUpdateGenre_Load(object sender, System.EventArgs e)
        {
            _LoadGenreData();
        }
    }
}
