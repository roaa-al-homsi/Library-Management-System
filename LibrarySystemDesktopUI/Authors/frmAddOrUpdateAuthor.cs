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
        private void _LoadDataAuthor()
        {
            if (_Mode == Mode.Add)
            {
                _Author = new Author();
                return;
            }
            _Author = Author.Find(_AuthorId);
            txtAdditionalDetails.Text = _Author.AdditionalDetails;
            txtCertificate.Text = _Author.Certificate;
            labAuthorId.Text = _Author.Id.ToString();
        }
        private void btnAddPerson_Click(object sender, System.EventArgs e)
        {
            frmAddUpdatePerson frmAddPerson = new frmAddUpdatePerson(-1);
            frmAddPerson.DataBack += DataBackPerson;
            frmAddPerson.ShowDialog();
        }
        private void DataBackPerson(object sender, int PersonId)
        {
            Person person = Person.Find(PersonId);
            if (person != null)
            {
                uc_PersonInfo1.ShowDataPerson(person);
                labPerson.Text = PersonId.ToString();
                picPerson.ImageLocation = (!string.IsNullOrWhiteSpace(person.ImagePath)) ? person.ImagePath : null;
                panelContainerAuthorInfo.Enabled = true;
            }
        }
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            _Author.AdditionalDetails = txtAdditionalDetails.Text;
            _Author.Certificate = txtCertificate.Text;
            _Author.PersonId = int.Parse(labPerson.Text);
            if (_Author.Save())
            {
                labAuthor.Visible = true;
                labAuthorId.Visible = true;
                labAuthorId.Text = _Author.Id.ToString();
                MessageBox.Show("Data Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmAddOrUpdateAuthor_Load(object sender, System.EventArgs e)
        {
            _LoadDataAuthor();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
