using LibraryStstem.Permission;
using LibrarySystem.Persons;
using LibrarySystemBusiness;
using System.Windows.Forms;

namespace LibrarySystem.Users
{
    public partial class frmAddUpdateUser : Form
    {
        private enum Mode { Add, Update }
        private Mode _mode;
        private User _user;
        private int _UserId;
        private int _PermissionOnlyUser = 0;

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
            _GetNamesOptionAllowedFromUserPermission(_user.Permission);
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
            _user.Permission = _PermissionOnlyUser;
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
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        { // Get the checked list box control
            CheckedListBox checkedListBox = sender as CheckedListBox;
            string item = checkedListBox.Items[e.Index].ToString();
            // Check if the item is being checked or unchecked

            if (e.NewValue == CheckState.Checked && item == "Books")
            {
                _PermissionOnlyUser += (int)ManagePermissions.enMainMenuPermission.Books;

            }
            else if (e.NewValue == CheckState.Checked && item == "Authors")
            {
                _PermissionOnlyUser += (int)ManagePermissions.enMainMenuPermission.Authors;
            }
            else if (e.NewValue == CheckState.Checked && item == "Customers")
            {
                _PermissionOnlyUser += (int)ManagePermissions.enMainMenuPermission.Customers;

            }
            else if (e.NewValue == CheckState.Checked && item == "Users")
            {
                _PermissionOnlyUser += (int)ManagePermissions.enMainMenuPermission.Users;
            }
            else if (e.NewValue == CheckState.Checked && item == "Genres")
            {
                _PermissionOnlyUser += (int)ManagePermissions.enMainMenuPermission.Genres;

            }
            else if (e.NewValue == CheckState.Checked && item == "Fines")
            {
                _PermissionOnlyUser += (int)ManagePermissions.enMainMenuPermission.Fines;

            }
            else if (e.NewValue == CheckState.Checked && item == "Borrowing")
            {
                _PermissionOnlyUser += (int)ManagePermissions.enMainMenuPermission.Books;

            }
            else if (e.NewValue == CheckState.Checked && item == "Reservations")
            {
                _PermissionOnlyUser += (int)ManagePermissions.enMainMenuPermission.Reservations;

            }

            else
            {
                _PermissionOnlyUser = 0;
            }
        }
        private void _GetNamesOptionAllowedFromUserPermission(int User_Permission)
        {
            int[] arrPermission = { 1, 2, 4, 8, 16, 32, 64, 128 };
            for (short i = 1; i <= arrPermission.Length; i++)
            {
                if (ManagePermissions.CheckAccessPermission(User_Permission, (ManagePermissions.enMainMenuPermission)arrPermission[i - 1]))
                {
                    checkedListBox1.SetItemChecked(i - 1, true);
                }
            }
        }

    }
}
