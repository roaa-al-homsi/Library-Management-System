using LibraryStstem.Persons;
using LibrarySystemBusiness;
using System.Windows.Forms;

namespace LibraryStstem.Authors
{
    public partial class frmAddOrUpdateAuthor : Form
    {
        private enum Mode { Add, Update };
        private Mode _Mode;
        private Author _Author;
        private int _AuthorId;
        public frmAddOrUpdateAuthor(int AuthorId)
        {
            InitializeComponent();
            _AuthorId = AuthorId;
            _Mode = (AuthorId != -1) ? Mode.Update : Mode.Add;
        }

        private void btnAddPerson_Click(object sender, System.EventArgs e)
        {
            frmAddPerson frmAddPerson = new frmAddPerson(-1);
            frmAddPerson.ShowDialog();
        }
    }
}
