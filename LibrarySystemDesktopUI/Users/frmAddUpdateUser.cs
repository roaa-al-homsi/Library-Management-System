using LibraryStstem.Persons;
using LibrarySystemBusiness;
using System.Windows.Forms;

namespace LibraryStstem.Users
{
    public partial class frmAddUpdateUser : Form
    {
        private enum Mode { Add, Update }
        private Mode _mode;
        private User _user;
        private int _UserId;

        public frmAddUpdateUser(int userId)
        {
            InitializeComponent();
            _UserId = userId;
            _mode = (_UserId == -1) ? Mode.Add : Mode.Update;
        }
        private void _LoadUserDataToForm()
        {
            if (_mode == Mode.Add)
            {
                this.Tag = "Add User";
                _user = new User();
                return;
            }
            this.Tag = "Update User";
            panelContainerUserInfo.Enabled = true;
            _user = User.FindById(_UserId);
            txtUserName.Text = _user.UserName;
            txtPassword.Text = _user.Password;
            txtPermission.Text = _user.Permission.ToString();
            labPersonId.Text = _user.PersonId.ToString();
        }
        private void frmAddUpdateUser_Load(object sender, System.EventArgs e)
        {
            _LoadUserDataToForm();
        }
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            _user.PersonId = int.Parse(labPersonId.Text);
            _user.UserName = txtUserName.Text;
            _user.Password = txtPassword.Text;
            _user.Permission = int.Parse(txtPermission.Text);
            if (_user.Save())
            {
                labUser.Visible = true;
                labUserId.Visible = true;
                labUserId.Text = _user.Id.ToString();
                MessageBox.Show("Data Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSelectPerson_Click(object sender, System.EventArgs e)
        {
            frmAddUpdatePerson frmAddUpdate = new frmAddUpdatePerson(_user.PersonId);
            frmAddUpdate.DataBack += DataBackPerson;
            frmAddUpdate.ShowDialog();
        }
        private void DataBackPerson(object sender, int PersonId)
        {
            Person person = Person.Find(PersonId);
            if (person != null)
            {
                uc_PersonInfo1.ShowDataPerson(person);
                labPersonId.Text = PersonId.ToString();
                picPerson.ImageLocation = (!string.IsNullOrWhiteSpace(person.ImagePath)) ? person.ImagePath : null;
                panelContainerUserInfo.Enabled = true;
            }
        }
    }
}
