using LibrarySystem;
using LibrarySystemBusiness;
using System;
using System.Windows.Forms;

namespace LibraryStstem.Login
{
    public partial class frmMainLogin : Form
    {
        static public User CurrentUser = User.FindByUserNameAndPassword(string.Empty, string.Empty);
        public static DateTime DateLoginToSystem;
        public static DateTime DateLogoutFromSystem;
        private byte _CounterFailedLogin = 0;
        private short _CounterTick = 60;
        public frmMainLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, System.EventArgs e)
        {
            CurrentUser = User.FindByUserNameAndPassword(txtUserName.Text, txtPassword.Text);
            if (CurrentUser != null)
            {
                this.Hide();
                frmMainMenuScreen frmMainMenu = new frmMainMenuScreen();
                frmMainMenu.Show();
            }
            else
            {
                _CounterFailedLogin++;
                labCheckLogin.Visible = true;
                if (_CounterFailedLogin == 3)
                {
                    txtPassword.Enabled = false;
                    txtUserName.Enabled = false;
                    labCheckLogin.Text = $"System Lock, Wait a few seconds to log in again";
                    _CounterFailedLogin = 0;
                    timer1.Enabled = true;
                    labTimer.Visible = true;
                }
                else
                { labCheckLogin.Text = $"Invalid username or password, You have {3 - _CounterFailedLogin} tries to login"; }
                txtUserName.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
        }
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void timer1_Tick_1(object sender, System.EventArgs e)
        {
            labTimer.Text = "00:" + _CounterTick.ToString();
            _CounterTick--;
            if (_CounterTick == 0)
            {
                btnLogin.Enabled = false;
                timer1.Enabled = false;
                txtPassword.Enabled = true;
                txtUserName.Enabled = true;
                labTimer.Visible = false;
                labCheckLogin.Visible = false;
                _CounterTick = 60;
            }
        }


    }
}
