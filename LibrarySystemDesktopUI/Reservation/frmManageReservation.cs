using LibrarySystemBusiness;
using System;
using System.Windows.Forms;

namespace LibrarySystem.Reservations
{
    public partial class frmManageReservations : Form
    {
        private frmMainMenuScreen _frmMainMenuScreen;

        public frmManageReservations(frmMainMenuScreen frmMainMenu)
        {
            InitializeComponent();
            _frmMainMenuScreen = frmMainMenu;
        }
        private void _RefreshReservationData()
        {
            dgvAllReservation.DataSource = Reservation.All();
        }
        private void frmManageReservation_Load(object sender, EventArgs e)
        {
            _RefreshReservationData();
        }
        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            _frmMainMenuScreen.OpenChildFormAsync(new frmAddUpdateReservations(-1));
        }
        private void ItemUpdate_Click(object sender, EventArgs e)
        {
            int ReservationId = (int)dgvAllReservation.CurrentRow.Cells[0].Value;
            _frmMainMenuScreen.OpenChildFormAsync(new frmAddUpdateReservations(ReservationId));
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ReservationId = (int)dgvAllReservation.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure delete this Customer?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (Reservation.Delete(ReservationId))
                {
                    MessageBox.Show("Delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delete Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            _RefreshReservationData();
        }
    }
}
