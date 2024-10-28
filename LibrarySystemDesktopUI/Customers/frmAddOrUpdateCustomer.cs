using LibrarySystem.Persons;
using LibrarySystemBusiness;
using System;
using System.Windows.Forms;
namespace LibrarySystem.Customers
{
    public partial class frmAddOrUpdateCustomer : Form
    {
        private enum Mode { Add, Update };
        private Mode _Mode;
        private Customer _Customer;
        private int _CustomerId;
        public frmAddOrUpdateCustomer(int CustomerId)
        {
            InitializeComponent();
            _CustomerId = CustomerId;
            _Mode = (_CustomerId == -1) ? Mode.Add : Mode.Update;
        }
        private void _LoadDataToForm()
        {
            if (_Mode == Mode.Add)
            {
                _Customer = new Customer();
                return;
            }
            panelContainerCustomerInfo.Enabled = true;
            _Customer = Customer.Find(_CustomerId);
            labCustomer.Visible = true;
            labCustomerId.Visible = true;
            labCustomerId.Text = _CustomerId.ToString();
            txtCardNumber.Text = _Customer.LibraryCardNumber.ToString();
            labPersonId.Text = _Customer.PersonId.ToString();
        }
        private void frmAddOrUpdateCustomer_Load(object sender, EventArgs e)
        {
            _LoadDataToForm();
        }
        private void btnSelectPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson addUpdatePerson = new frmAddUpdatePerson(_Customer.PersonId);
            addUpdatePerson.DataBack += DataBackPerson;
            addUpdatePerson.ShowDialog();
        }
        private void DataBackPerson(object sender, int PersonId)
        {
            Person person = Person.Find(PersonId);
            if (person != null)
            {
                uc_PersonInfo1.ShowDataPerson(person);
                labPersonId.Text = PersonId.ToString();
                picPerson.ImageLocation = (!string.IsNullOrWhiteSpace(person.ImagePath)) ? person.ImagePath : null;
                panelContainerCustomerInfo.Enabled = true;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Customer.PersonId = int.Parse(labPersonId.Text);
            _Customer.LibraryCardNumber = txtCardNumber.Text;
            if (_Customer.Save())
            {
                labCustomer.Visible = true;
                labCustomerId.Visible = true;
                labCustomerId.Text = _Customer.Id.ToString();
                MessageBox.Show("Data Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
