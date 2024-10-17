using LibrarySystemBusiness;
using System.Windows.Forms;
namespace LibraryStstem.Books
{
    public partial class frmAddOrUpdateBook : Form
    {
        private enum Mode { Add = 1, Update = 0 };
        private Mode _Mode;
        private int _BookId;
        private Book _Book;
        public frmAddOrUpdateBook(int BookId)
        {
            InitializeComponent();
            _BookId = BookId;
            _Mode = (BookId == -1) ? Mode.Add : Mode.Update;
        }
        private void _LoadData()
        {
            if (_Mode == Mode.Add)
            {
                _Book = new Book();
                return;
            }
            _Book = Book.Find(_BookId);
            if (_Book == null)
            {
                MessageBox.Show("This form will be closed because there is no book with this id");
            }
            uctrlBookInfo1.Title = _Book.Title;
            uctrlBookInfo1.ISBN = _Book.ISBN;
            uctrlBookInfo1.PublishingHouse = _Book.PublishingHouse;
            uctrlBookInfo1.Genre = _Book.Genre;
            uctrlBookInfo1.SellingPrice = _Book.SellingPrice;
            uctrlBookInfo1.PublicationDate = _Book.PublicationDate;
            uctrlBookInfo1.PublishingHouse = _Book.PublishingHouse;
            uctrlBookInfo1.BorrowingPrice = _Book.BorrowingPrice;
            uctrlBookInfo1.NumberOfPages = _Book.NumberOfPages;
            uctrlBookInfo1.AdditionalDetails = _Book.AdditionalDetails;
            uctrlBookInfo1.ComboBoxName = Author.Find(_Book.AuthorId).Person.Name;
            if (!string.IsNullOrWhiteSpace(_Book.ImagePath))
            {
                uctrlBookInfo1.LinkRemove = true;
                uctrlBookInfo1.Image = _Book.ImagePath;
            }
            else
            {
                uctrlBookInfo1.LinkRemove = false;
                uctrlBookInfo1.Image = null;
            }
        }
        private void uctrlBookInfo1_Load(object sender, System.EventArgs e)
        {

        }
        private void FillBookBeforeSave()
        {
            int AuthorId = Author.GetAuthorIdByName(uctrlBookInfo1.ComboBoxName);
            _Book.Title = uctrlBookInfo1.Title;
            _Book.ISBN = uctrlBookInfo1.ISBN;
            _Book.PublishingHouse = uctrlBookInfo1.PublishingHouse;
            _Book.SellingPrice = uctrlBookInfo1.SellingPrice;
            _Book.PublicationDate = uctrlBookInfo1.PublicationDate;
            _Book.BorrowingPrice = uctrlBookInfo1.BorrowingPrice;
            _Book.AdditionalDetails = uctrlBookInfo1.AdditionalDetails;
            _Book.NumberOfPages = uctrlBookInfo1.NumberOfPages;
            _Book.Genre = uctrlBookInfo1.Genre;
            _Book.AuthorId = AuthorId;
            _Book.ImagePath = (uctrlBookInfo1.Image != null) ? uctrlBookInfo1.Image : null;

        }
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            FillBookBeforeSave();
            if (_Book.Save())
            {
                MessageBox.Show("Data Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmAddOrUpdateBook_Load(object sender, System.EventArgs e)
        {
            _LoadData();
        }
    }
}
