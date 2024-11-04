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
        private void _CalculatePermissionUser()
        {
            foreach (var checkedItem in checkedListBox1.CheckedItems)
            {
                string item = checkedItem.ToString();
                if (item == "Books")
                {
                    _PermissionOnlyUser += (int)ManagePermissions.enMainMenuPermission.Books;
                }
                else if (item == "Authors")
                {
                    _PermissionOnlyUser += (int)ManagePermissions.enMainMenuPermission.Authors;
                }
                else if (item == "Customers")
                {
                    _PermissionOnlyUser += (int)ManagePermissions.enMainMenuPermission.Customers;
                }
                else if (item == "Users")
                {
                    _PermissionOnlyUser += (int)ManagePermissions.enMainMenuPermission.Users;
                }
                else if (item == "Genres")
                {
                    _PermissionOnlyUser += (int)ManagePermissions.enMainMenuPermission.Genres;
                }
                else if (item == "Fines")
                {
                    _PermissionOnlyUser += (int)ManagePermissions.enMainMenuPermission.Fines;
                }
                else if (item == "Borrowing")
                {
                    _PermissionOnlyUser += (int)ManagePermissions.enMainMenuPermission.Borrowing;
                }
                else if (item == "Reservations")
                {
                    _PermissionOnlyUser += (int)ManagePermissions.enMainMenuPermission.Reservations;
                }
                else if (item == "Logins")
                {
                    _PermissionOnlyUser += (int)ManagePermissions.enMainMenuPermission.Logins;
                }
            }
        }
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            _PermissionOnlyUser = 0; // Reset and calculate the combined permission
            _CalculatePermissionUser();

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
        private void _GetNamesOptionAllowedFromUserPermission(int User_Permission)
        {
            checkedListBox1.BeginUpdate(); // Pause updates for performance
            try
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    string itemName = checkedListBox1.Items[i].ToString();
                    int permissionValue = 0;

                    // Map each item to its corresponding permission value
                    switch (itemName)
                    {
                        case "Books":
                            permissionValue = (int)ManagePermissions.enMainMenuPermission.Books;
                            break;
                        case "Authors":
                            permissionValue = (int)ManagePermissions.enMainMenuPermission.Authors;
                            break;
                        case "Customers":
                            permissionValue = (int)ManagePermissions.enMainMenuPermission.Customers;
                            break;
                        case "Users":
                            permissionValue = (int)ManagePermissions.enMainMenuPermission.Users;
                            break;
                        case "Genres":
                            permissionValue = (int)ManagePermissions.enMainMenuPermission.Genres;
                            break;
                        case "Fines":
                            permissionValue = (int)ManagePermissions.enMainMenuPermission.Fines;
                            break;
                        case "Borrowing":
                            permissionValue = (int)ManagePermissions.enMainMenuPermission.Borrowing;
                            break;
                        case "Reservations":
                            permissionValue = (int)ManagePermissions.enMainMenuPermission.Reservations;
                            break;
                        case "Logins":
                            permissionValue = (int)ManagePermissions.enMainMenuPermission.Logins;
                            break;
                            // Add other cases as necessary
                    }

                    // Check if the permission bit is set in User_Permission
                    if ((User_Permission & permissionValue) == permissionValue)
                    {
                        checkedListBox1.SetItemChecked(i, true);
                    }
                    else
                    {
                        checkedListBox1.SetItemChecked(i, false);
                    }
                }
            }
            finally
            {
                checkedListBox1.EndUpdate(); // Resume updates
            }
        }

    }

}
