﻿using LibrarySystemBusiness;
using System.Windows.Forms;
namespace LibraryStstem
{
    public partial class uc_PersonInfo : UserControl
    {
        public uc_PersonInfo()
        {
            InitializeComponent();
        }

        public void ShowDataPerson(Person person)
        {
            if (person != null)
            {
                labPersoId.Text = person.Id.ToString();
                txtFullName.Text = person.Name;
                txtCountry.Text = person.Country;
                txtContactInfo.Text = person.ContactInfo;
                picPerson.ImageLocation = (!string.IsNullOrWhiteSpace(person.ImagePath)) ? person.ImagePath : null;
            }
        }
    }
}