using Guna.UI2.WinForms;
using LibrarySystem.Authors;
using LibrarySystem.BorrowingReturn;
using LibrarySystem.Customers;
using LibrarySystem.Fines;
using LibrarySystem.Genres;
using LibrarySystem.Reservations;
using LibrarySystem.Users;
using LibrarySystem.Books;
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
                    _currentButton.BackColor = Color.FromArgb(53, 41, 123);
                    _currentButton.ForeColor = Color.White;
                    _currentButton.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }

                _currentButton = (Guna2Button)btnSender;
                _currentButton.BackColor = Color.White;
                _currentButton.ForeColor = Color.FromArgb(53, 41, 123);
                _currentButton.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private void btnAllBooks_Click(object sender, System.EventArgs e)
        {
            btnTitle.Image = btnAllBooks.Image;
            OpenChildFormAsync(new frmAllBooks(this), sender);
        }
        private void btnAuthors_Click(object sender, System.EventArgs e)
        {
            btnTitle.Image = btnAuthors.Image;
            OpenChildFormAsync(new frmManageAuthors(this), sender);
        }
        private void btnCustomers_Click(object sender, System.EventArgs e)
        {
            btnTitle.Image = btnCustomers.Image;
            OpenChildFormAsync(new frmManageCustomers(this), sender);
        }
        private void btnUsers_Click(object sender, System.EventArgs e)
        {
            btnTitle.Image = btnUsers.Image;
            OpenChildFormAsync(new frmManageUsers(this), sender);
        }
        private void btnGenres_Click(object sender, System.EventArgs e)
        {
            btnTitle.Image = btnGenres.Image;
            OpenChildFormAsync(new frmManageGenres(this), sender);
        }
        private void btnFines_Click(object sender, System.EventArgs e)
        {
            btnTitle.Image = btnFines.Image;
            OpenChildFormAsync(new frmManageFines(this), sender);
        }
        private void btnBorrowing_Click(object sender, System.EventArgs e)
        {
            btnTitle.Image = btnBorrowing.Image;
            OpenChildFormAsync(new frmManageBorrowing(this), sender);
        }
        private void btnManageReservation_Click(object sender, System.EventArgs e)
        {
            btnTitle.Image = btnManageReservation.Image;
            OpenChildFormAsync(new frmManageReservations(this), sender);
        }
    }
}
