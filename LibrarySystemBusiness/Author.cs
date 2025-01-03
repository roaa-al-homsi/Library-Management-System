﻿using LibrarySystemDataAccess;
using System.Data;

namespace LibrarySystemBusiness
{
    public class Author
    {
        private enum Mode { Add, Update };
        private Mode _Mode;
        public Person Person { get; private set; }//composition

        public int Id { get; set; }
        public int PersonId { get; set; }
        public string Certificate { get; set; }
        public string AdditionalDetails { get; set; }

        public Author()
        {
            Person Person = new Person();
            this.Id = -1;
            this.PersonId = -1;
            this.Certificate = string.Empty;
            this.AdditionalDetails = string.Empty;
            _Mode = Mode.Add;
        }
        private Author(int Id, string Certificate, string AdditionalDetails, int PersonId)
        {
            Person = Person.Find(PersonId);
            this.Id = Id;
            this.Certificate = Certificate;
            this.AdditionalDetails = AdditionalDetails;
            this.PersonId = PersonId;
            _Mode = Mode.Update;
        }

        private bool _Add()
        {
            this.Id = AuthorData.Add(Certificate, this.PersonId, AdditionalDetails);
            return (Id != -1);
        }
        private bool _Update()
        {//validation
            return AuthorData.Update(this.Id, this.Certificate, this.PersonId, this.AdditionalDetails);
        }
        public bool ReadyAuthor()
        {
            if (!Person.Exist(this.PersonId))
            {
                return false;
            }
            return true;
        }
        public bool Save()
        {
            if (!ReadyAuthor())
            { return false; }

            switch (_Mode)
            {
                case Mode.Add:
                    return _Add();
                case Mode.Update:
                    return _Update();
            }
            return false;
        }
        static public DataTable All()
        {
            return AuthorData.All();
        }
        static public bool Delete(int Id)
        {
            if (!Author.Exist(Id))
            {
                return false;
            }

            if (Book.ExistByAuthorId(Id))
            {
                return false;
            }
            int PersonId = AuthorData.GetPersonIdByAuthorId(Id);
            if (!AuthorData.Delete(Id))
            {
                return false;
            }
            else
            {
                return Person.DeletePerson(PersonId);
            }
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
        static public bool Exist(int Id)
        {
            return AuthorData.Exist(Id);
        }
        static public int GetAuthorIdByName(string Name)
        {
            return AuthorData.GetAuthorIdByName(Name);
        }
        static public string GetNameAuthorById(int Id)
        {
            return AuthorData.GetNameAuthorById(Id);
        }
        static public DataTable GetAuthorsNames()
        {
            return AuthorData.GetAuthorsNames();
        }
    }
}
