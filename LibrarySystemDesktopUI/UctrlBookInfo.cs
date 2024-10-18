using LibrarySystemBusiness;
using System.Data;
using System.Windows.Forms;
namespace LibraryStstem
{
    public partial class UctrlBookInfo : UserControl
    {

        public UctrlBookInfo()
        {
            InitializeComponent();
        }

        public string Title
        {
            set { txtTitle.Text = value; }
            get { return txtTitle.Text; }
        }
        public string ISBN
        {
            set { txtISBN.Text = value; }
            get { return txtISBN.Text; }
        }
        public string Genre
        {
            set { txtGenre.Text = value; }
            get { return txtGenre.Text; }
        }
        public decimal SellingPrice
        {
            set { txtSellingPrice.Text = value.ToString(); }
            get { return decimal.Parse(txtSellingPrice.Text); }
        }
        public int PublicationDate
        {
            set { txtPublicationDate.Text = value.ToString(); }
            get { return int.Parse(txtPublicationDate.Text); }
        }
        public string PublishingHouse
        {
            set { txtPublishingHouse.Text = value; }
            get { return txtPublishingHouse.Text; }
        }
        public decimal BorrowingPrice
        {
            set { txtBorrowingPrice.Text = value.ToString(); }
            get { return decimal.Parse(txtBorrowingPrice.Text); }
        }
        public int NumberOfPages
        {
            set { txtNumberOfPages.Text = value.ToString(); }
            get { return int.Parse(txtNumberOfPages.Text); }
        }
        public string AdditionalDetails
        {
            set { txtAdditionalDetails.Text = value; }
            get { return txtAdditionalDetails.Text; }
        }
        public string Image
        {
            set { pictBook.ImageLocation = value; }
            get { return pictBook.ImageLocation; }
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
        public string ComboBoxName
        {
            set { comboAuthors.SelectedIndex = comboAuthors.FindString(value); }
            get { return comboAuthors.Text; }
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
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                pictBook.Load(selectedFilePath);
                pictBook.ImageLocation = selectedFilePath;
            }
        }

        private void linkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictBook.ImageLocation = null;
        }

        private void _FillAuthorsINComboBox()
        {
            DataTable dataTable = Author.GetAuthorsNames();
            foreach (DataRow row in dataTable.Rows)
            {
                comboAuthors.Items.Add(row["Full Name"]);
            }
        }

        private void UctrlBookInfo_Load(object sender, System.EventArgs e)
        {
            _FillAuthorsINComboBox();
            comboAuthors.SelectedIndex = 0;
        }

        private void txtBoxLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtBoxNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

