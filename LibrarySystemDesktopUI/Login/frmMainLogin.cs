using System.Windows.Forms;

namespace LibraryStstem.Login
{
    public partial class frmMainLogin : Form
    {
        private byte _CounterFailedLogin = 0;
        private short _CounterTick = 60;
        public frmMainLogin()
        {
            InitializeComponent();
        }



        private void timer1_Tick(object sender, System.EventArgs e)
        {
            labTimer.Text = "00:" + _CounterTick.ToString();
            _CounterTick--;
            if (_CounterTick == 0)
            {
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
