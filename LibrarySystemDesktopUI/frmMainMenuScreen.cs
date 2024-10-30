using Guna.UI2.WinForms;
using LibraryStstem.Logins;
using LibraryStstem.Permission;
using LibrarySystem.Authors;
using LibrarySystem.Books;
using LibrarySystem.BorrowingReturn;
using LibrarySystem.Customers;
using LibrarySystem.Fines;
using LibrarySystem.Genres;
using LibrarySystem.Reservations;
using LibrarySystem.Users;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class frmMainMenuScreen : Form
    {
        public frmMainMenuScreen()
        {
            InitializeComponent();
        }

        private Guna2Button _currentButton;
        private Form _activeForm;

        private void _ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (_currentButton != null)
                {
                    _currentButton.BackColor = Color.FromArgb(175, 238, 238);
                    _currentButton.ForeColor = Color.White;
                    _currentButton.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }

                _currentButton = (Guna2Button)btnSender;
                _currentButton.BackColor = Color.White;
                _currentButton.ForeColor = Color.FromArgb(175, 238, 238);
                _currentButton.Font = new System.Drawing.Font("Comic Sans MS", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        public void OpenChildFormAsync(Form childForm, object btnSender)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            _ActivateButton(btnSender);
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainMenu.Controls.Add(childForm);
            panelMainMenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            if (childForm.Tag != null)
            {
                btnTitle.Text = childForm.Tag.ToString();
            }
            else
            {
                btnTitle.Text = childForm.Text;
            }
        }
        public void OpenChildFormAsync(Form childForm)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainMenu.Controls.Add(childForm);
            panelMainMenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            if (childForm.Tag != null)
            {
                btnTitle.Text = childForm.Tag.ToString();
            }
            else
            {
                btnTitle.Text = childForm.Text;
            }
        }
        private void _MessageAccessDenied()
        {
            MessageBox.Show("Access Denied!! You don't have permission to use this feature." +
                     "Please contact your administrator for assistance..", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        private void btnAllBooks_Click(object sender, System.EventArgs e)
        {
            if (!ManagePermissions.CheckAccessPermission(ManagePermissions.enMainMenuPermission.Books))
            {
                _MessageAccessDenied();
                return;
            }
            btnTitle.Image = btnAllBooks.Image;
            OpenChildFormAsync(new frmAllBooks(this), sender);
        }
        private void btnAuthors_Click(object sender, System.EventArgs e)
        {
            if (!ManagePermissions.CheckAccessPermission(ManagePermissions.enMainMenuPermission.Authors))
            {
                _MessageAccessDenied();
                return;
            }
            btnTitle.Image = btnAuthors.Image;
            OpenChildFormAsync(new frmManageAuthors(this), sender);
        }
        private void btnCustomers_Click(object sender, System.EventArgs e)
        {
            if (!ManagePermissions.CheckAccessPermission(ManagePermissions.enMainMenuPermission.Customers))
            {
                _MessageAccessDenied();
                return;
            }
            btnTitle.Image = btnCustomers.Image;
            OpenChildFormAsync(new frmManageCustomers(this), sender);
        }
        private void btnUsers_Click(object sender, System.EventArgs e)
        {
            if (!ManagePermissions.CheckAccessPermission(ManagePermissions.enMainMenuPermission.Users))
            {
                _MessageAccessDenied();
                return;
            }
            btnTitle.Image = btnUsers.Image;
            OpenChildFormAsync(new frmManageUsers(this), sender);
        }
        private void btnGenres_Click(object sender, System.EventArgs e)
        {
            if (!ManagePermissions.CheckAccessPermission(ManagePermissions.enMainMenuPermission.Genres))
            {
                _MessageAccessDenied();
                return;
            }
            btnTitle.Image = btnGenres.Image;
            OpenChildFormAsync(new frmManageGenres(this), sender);
        }
        private void btnFines_Click(object sender, System.EventArgs e)
        {
            if (!ManagePermissions.CheckAccessPermission(ManagePermissions.enMainMenuPermission.Fines))
            {
                _MessageAccessDenied();
                return;
            }
            btnTitle.Image = btnFines.Image;
            OpenChildFormAsync(new frmManageFines(this), sender);
        }
        private void btnBorrowing_Click(object sender, System.EventArgs e)
        {
            if (!ManagePermissions.CheckAccessPermission(ManagePermissions.enMainMenuPermission.Borrowing))
            {
                _MessageAccessDenied();
                return;
            }
            btnTitle.Image = btnBorrowing.Image;
            OpenChildFormAsync(new frmManageBorrowing(this), sender);
        }
        private void btnManageReservation_Click(object sender, System.EventArgs e)
        {
            if (!ManagePermissions.CheckAccessPermission(ManagePermissions.enMainMenuPermission.Reservations))
            {
                _MessageAccessDenied();
                return;
            }
            btnTitle.Image = btnManageReservation.Image;
            OpenChildFormAsync(new frmManageReservations(this), sender);
        }
        private void frmMainMenuScreen_Load(object sender, System.EventArgs e)
        {
            frmMainLogin.DateLoginToSystem = DateTime.Now;
            labLoginDate.Text = frmMainLogin.DateLoginToSystem.ToString();
            labCurrentUser.Text = frmMainLogin.CurrentUser.UserName;
            if (!string.IsNullOrEmpty(frmMainLogin.CurrentUser.Person.ImagePath))
            {
                picCurrentUser.ImageLocation = frmMainLogin.CurrentUser.Person.ImagePath;
            }
        }
        private void btnLogins_Click(object sender, EventArgs e)
        {
            if (!ManagePermissions.CheckAccessPermission(ManagePermissions.enMainMenuPermission.Logins))
            {
                _MessageAccessDenied();
                return;
            }
            btnTitle.Image = btnLogins.Image;
            OpenChildFormAsync(new ViewLogins(), sender);
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMainLogin mainLogin = new frmMainLogin();
            mainLogin.Show();
        }
    }
}
