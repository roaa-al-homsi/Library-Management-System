using System;
using System.Windows.Forms;

namespace LibraryStstem
{
    public partial class UctrlPersonInfo : UserControl
    {
        public UctrlPersonInfo()
        {
            InitializeComponent();
        }
        public string FullName
        {
            set { txtFullName.Text = value; }
            get { return txtFullName.Text; }
        }
        public string Country
        {
            set { txtCountry.Text = value; }
            get { return txtCountry.Text; }
        }
        public string ContactInfo
        {
            set { txtContactInfo.Text = value; }
            get { return txtContactInfo.Text; }
        }
        public DateTime BirthDate
        {
            set { TBirthDate.Value = value; }
            get { return TBirthDate.Value; }
        }
        public string ImagePath
        {
            set { picPerson.ImageLocation = value; }
            get { return picPerson.ImageLocation; }
        }
        public int personId
        {
            set { labPersoId.Text = value.ToString(); }
            get { return int.Parse(labPersoId.Text); }
        }
        public bool LinkRemove
        {
            set { linkRemove.Visible = value; }
            get { return linkRemove.Enabled; }
        }
        public bool LinkSet
        {
            set { linkSet.Visible = value; }
            get { return linkSet.Enabled; }
        }
        public bool IsVisibleLabPersonId
        {
            set { labPersoId.Visible = value; }
            get { return labPersoId.Visible; }
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
                picPerson.ImageLocation = selectedFilePath;
            }
        }
        private void linkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picPerson.ImageLocation = null;
        }
        private void txtBoxLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
