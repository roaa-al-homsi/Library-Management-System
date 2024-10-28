using LibrarySystemBusiness;
using System;
using System.Windows.Forms;

namespace LibrarySystem.Reservations
{
    public partial class frmAddUpdateReservations : Form
    {
        private enum Mode { Add, Update };
        private Mode _Mode;
        private int _ReservationId;
        private Reservation _Reservation;
        public frmAddUpdateReservations(int ReservationId)
        {
            InitializeComponent();
            _ReservationId = ReservationId;
            _Mode = (_ReservationId == -1) ? Mode.Add : Mode.Update;
        }
        private void _LoadReservationDataToForm()
        {
            if (_Mode == Mode.Add)
            {
                this.Text = "Add Reservation";
                _Reservation = new Reservation();
                return;
            }
            this.Text = "Update Reservation";
            _Reservation = Reservation.Find(_ReservationId);
            txtCopyId.Text = _Reservation.CopyId.ToString();
            txtCustomerId.Text = _Reservation.CustomerId.ToString();
            TimePicReservationDate.Value = _Reservation.ReservationDate;

        }
        private void _PrintMessage(string Text, string Caption, MessageBoxIcon icon)
        {
            MessageBox.Show($"{Text}", Caption, MessageBoxButtons.OK, icon);
        }
        private void btnViewCustomerInfo_Click(object sender, EventArgs e)
        {
            panelCustomerInfo.Visible = true;
            dgvCustomerInfo.DataSource = Customer.ViewSpecificCustomer(int.Parse(txtCustomerId.Text));
        }
        private void btnViewBookCopyInfo_Click(object sender, EventArgs e)
        {
            PanelBookCopynfo.Visible = true;
            dgvCopyInfo.DataSource = BookCopy.ViewInfoSpecificCopyBook(int.Parse(txtCopyId.Text));
        }
        private void _FillRecordBeforeSave()
        {
            _Reservation.CopyId = int.Parse(txtCopyId.Text);
            _Reservation.CustomerId = int.Parse(txtCustomerId.Text);
            _Reservation.ReservationDate = TimePicReservationDate.Value;
        }

        private void frmAddUpdateReservations_Load(object sender, EventArgs e)
        {
            _LoadReservationDataToForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Customer.Exist(int.Parse(txtCustomerId.Text)))
            {
                _PrintMessage("Failed,There is no customer with this id", "Error", MessageBoxIcon.Error);
                return;
            }
            if (!BookCopy.Exist(int.Parse(txtCopyId.Text)))
            {
                _PrintMessage("Failed,There is no copy with this id", "Error", MessageBoxIcon.Error);
                return;
            }
            _FillRecordBeforeSave();
            if (_Reservation.Save())
            {
                _PrintMessage("Data Saved Successfully", "Information", MessageBoxIcon.Information);
            }
        }
    }
}
