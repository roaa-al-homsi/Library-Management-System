﻿using LibrarySystem;
using LibrarySystemBusiness;
using System.Windows.Forms;

namespace LibrarySystem.Users
{
    public partial class frmManageUsers : Form
    {
        private frmMainMenuScreen _MainMenuScreen;
        public frmManageUsers(frmMainMenuScreen frmMainMenuScreen)
        {
            InitializeComponent();
            _MainMenuScreen = frmMainMenuScreen;
        }

        private void _RefreshUsersData()
        {
            dgvAllUsers.DataSource = User.All();
        }

        private void frmManageUsers_Load(object sender, System.EventArgs e)
        {
            _RefreshUsersData();
        }

        private void btnAddUser_Click(object sender, System.EventArgs e)
        {
            _MainMenuScreen.OpenChildFormAsync(new frmAddUpdateUser(-1));
        }

        private void ItemUpdate_Click(object sender, System.EventArgs e)
        {
            int UserId = (int)dgvAllUsers.CurrentRow.Cells[0].Value;
            _MainMenuScreen.OpenChildFormAsync(new frmAddUpdateUser(UserId));
        }

        private void ItemDelete_Click(object sender, System.EventArgs e)
        {
            int UserId = (int)dgvAllUsers.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure delete this Customer?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (User.Delete(UserId))
                {
                    MessageBox.Show("Delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delete Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            _RefreshUsersData();
        }
    }
}
