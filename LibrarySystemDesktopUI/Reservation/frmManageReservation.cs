using LibrarySystem;
using LibrarySystemBusiness;
using System;
using System.Windows.Forms;

namespace LibraryStstem.Reservations
{
    public partial class frmManageReservations : Form
    {
        private frmMainMenuScreen _frmMainMenuScreen;

        public frmManageReservations(frmMainMenuScreen frmMainMenu)
        {
            InitializeComponent();
            _frmMainMenuScreen = frmMainMenu;
        }
        private void _RefreshData()
        {
            dgvAllReservation.DataSource = Reservation.All();
        }
        private void frmManageReservation_Load(object sender, EventArgs e)
        {
            _RefreshData();
        }
    }
}
