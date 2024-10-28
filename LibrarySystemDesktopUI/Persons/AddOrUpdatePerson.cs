using LibrarySystemBusiness;
using System;
using System.Windows.Forms;
namespace LibrarySystem.Persons
{
    public partial class frmAddUpdatePerson : Form
    {
        //Declare a delegate 
        public delegate void DataBackEventHandle(object sender, int PersonId);
        public event DataBackEventHandle DataBack;

        private enum Mode { Add, Update }
        private Mode _Mode;
        private int _PersonId;
        private Person _Person;
        public frmAddUpdatePerson(int PersonId)
        {
            InitializeComponent();
            _PersonId = PersonId;
            _Mode = (_PersonId == -1) ? Mode.Add : Mode.Update;
        }
        private void _LoadPersonData()
        {
            if (_Mode == Mode.Add)
            {
                this.Text = "Add Person";
                _Person = new Person();
                return;
            }
            this.Text = "Update Person";
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
        private void _BackDefaultForm()
        {
            txtFullName.Text = "???";
            txtCountry.Text = "???";
            txtContactInfo.Text = "???";
            TimePicBirthDate.Value = new DateTime(1999, 1, 1);
            labPersoId.Visible = false;
            picPerson.ImageLocation = null;
        }
        private void linkSet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                picPerson.Load(selectedFilePath);
                picPerson.ImageLocation = selectedFilePath;
            }
        }
        private void linkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picPerson.ImageLocation = null;
        }
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            _FillPersonBeforeSave();
            if (_Person.Save())
            {
                labPerson.Visible = true;
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
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            _BackDefaultForm();
            this.Close();
        }
        private void frmAddPerson_Load(object sender, EventArgs e)
        {
            _LoadPersonData();
        }
    }
}
