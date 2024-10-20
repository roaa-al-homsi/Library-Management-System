using LibrarySystemBusiness;
using System;
using System.Windows.Forms;
namespace LibraryStstem.Persons
{
    public partial class frmAddPerson : Form
    {
        //Declare a delegate 
        public delegate void DataBackEventHandle(object sender, int PersonId);
        public event DataBackEventHandle DataBack;

        private enum Mode { Add, Update }
        private Mode _Mode;
        private int _PersonId;
        private Person _Person;
        public frmAddPerson(int Id)
        {
            InitializeComponent();
            _PersonId = Id;
            _Mode = (_PersonId == -1) ? Mode.Add : Mode.Update;
        }
        private void _LoadPersonData()
        {
            if (_Mode == Mode.Add)
            {
                _Person = new Person();
                return;
            }
            _Person = Person.Find(_PersonId);
            txtFullName.Text = _Person.Name;
            txtCountry.Text = _Person.Country;
            txtContactInfo.Text = _Person.ContactInfo;
            TimePicBirthDate.Value = _Person.BirthDate;
            picPerson.ImageLocation = (!string.IsNullOrWhiteSpace(_Person.ImagePath)) ? _Person.ImagePath : null;
            labPersoId.Visible = true;
            labPersoId.Text = _Person.Id.ToString();
            linkRemove.Visible = (!string.IsNullOrWhiteSpace(_Person.ImagePath)) ? true : false;
        }

        private void _FillPersonBeforeSave()
        {
            _Person.Name = txtFullName.Text;
            _Person.ContactInfo = txtContactInfo.Text;
            _Person.BirthDate = TimePicBirthDate.Value;
            _Person.Country = txtCountry.Text;
            _Person.ImagePath = (!string.IsNullOrWhiteSpace(picPerson.ImageLocation)) ? picPerson.ImageLocation : null;
        }
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            _FillPersonBeforeSave();
            if (_Person.Save())
            {
                labPersoId.Visible = true;
                labPersoId.Text = _Person.Id.ToString();
                MessageBox.Show("Data Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataBack?.Invoke(this, _Person.Id);
            this.Close();
        }
        private void _BackDefaultForm()
        {
            txtFullName.Text = "???";
            txtCountry.Text = "???";
            txtContactInfo.Text = "???";
            TimePicBirthDate.Value = new DateTime(1999, 1, 1);
            labPersoId.Visible = false;
            picPerson.ImageLocation = null;
        }
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            _BackDefaultForm();
        }
    }
}
