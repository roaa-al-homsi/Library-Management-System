using LibrarySystemBusiness;
using System;
using System.Windows.Forms;
namespace LibrarySystem.Genres
{
    public partial class frmViewGenresBooks : Form
    {
        private int _GenreId;
        public frmViewGenresBooks(int GenreId)
        {
            InitializeComponent();
            _GenreId = GenreId;
        }
        private void _RefreshBooksGenreData()
        {
            dgvAllBooksGeners.DataSource = Book.GetBooksForSpecificGenre(_GenreId);
        }
        private void frmViewGenresBooks_Load(object sender, EventArgs e)
        {
            _RefreshBooksGenreData();
        }
    }
}
