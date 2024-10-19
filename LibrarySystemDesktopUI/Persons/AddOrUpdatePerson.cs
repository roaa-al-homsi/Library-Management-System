using LibrarySystemBusiness;
using System;
using System.Windows.Forms;
namespace LibraryStstem.Persons
{
    public partial class frmAddPerson : Form
    {
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
            uctrlPersonInfo1.FullName = _Person.Name;
            uctrlPersonInfo1.Country = _Person.Country;
            uctrlPersonInfo1.ContactInfo = _Person.ContactInfo;
            uctrlPersonInfo1.BirthDate = _Person.BirthDate;
            //image
        }

        private void uctrlPersonInfo1_Load(object sender, System.EventArgs e)
        {

        }
        private void _FillPersonBeforeSave()
        {
            _Person.Name = uctrlPersonInfo1.FullName;
            _Person.ContactInfo = uctrlPersonInfo1.ContactInfo;
            _Person.BirthDate = uctrlPersonInfo1.BirthDate;
            _Person.Country = uctrlPersonInfo1.Country;
            _Person.ImagePath = (!string.IsNullOrWhiteSpace(uctrlPersonInfo1.ImagePath)) ? uctrlPersonInfo1.ImagePath : null;

        }
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            _FillPersonBeforeSave();
            if (_Person.Save())
            {
                MessageBox.Show("Data Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void _BackDefaultForm()
        {
            uctrlPersonInfo1.FullName = "???";
            uctrlPersonInfo1.Country = "???";
            uctrlPersonInfo1.ContactInfo = "???";
            uctrlPersonInfo1.BirthDate = new DateTime(1999, 1, 1);
            labPersoId.Text = "???";
            uctrlPersonInfo1.ImagePath = null;
        }
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            _BackDefaultForm();
        }
    }
}
