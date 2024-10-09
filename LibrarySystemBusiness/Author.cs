using LibrarySystemDataAccess;
using System.Data;

namespace LibrarySystemBusiness
{
    public class Author
    {
        private enum ModeAuthor { Add, Update };
        private ModeAuthor _Mode;
        public Person Person { get; private set; }//composition

        public int Id { get; set; }
        public int PersonId { get; set; }
        public string Certificate { get; set; }
        public string AdditionalDetails { get; set; }

        public Author(int PersonId)
        {
            Person = Person.Find(PersonId);
            this.Id = -1;
            this.PersonId = PersonId;
            this.Certificate = string.Empty;
            this.AdditionalDetails = string.Empty;
            _Mode = ModeAuthor.Add;
        }
        private Author(int Id, string Certificate, string AdditionalDetails, int PersonId)
        {
            Person = Person.Find(PersonId);
            this.Id = Id;
            this.Certificate = Certificate;
            this.AdditionalDetails = AdditionalDetails;
            this.PersonId = PersonId;
            _Mode = ModeAuthor.Update;
        }

        private bool Add()
        {//validation
            this.Id = AuthorData.Add(Certificate, this.PersonId, AdditionalDetails);
            return (Id != -1);
        }
        private bool Update()
        {//validation
            return AuthorData.Update(this.Id, this.Certificate, this.PersonId, this.AdditionalDetails);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case ModeAuthor.Add:
                    return Add();
                case ModeAuthor.Update:
                    return Update();
            }
            return false;
        }
        static public DataTable All()
        {
            return AuthorData.All();
        }
        static public bool Delete(int Id)
        {
            return AuthorData.Delete(Id);
        }
        static public Author Find(int Id)
        {
            int PersonId = -1;
            string Certificate = string.Empty;
            string AdditionalDetails = string.Empty;

            if (AuthorData.GetAuthorById(Id, ref PersonId, ref Certificate, ref AdditionalDetails))
            {
                return new Author(Id, Certificate, AdditionalDetails, PersonId);
            }
            return null;
        }


    }
}
