using LibrarySystemDataAccess;
using System;

namespace LibrarySystemBusiness
{
    public class Person
    {
        public enum Mode { Add, Update };
        private Mode _Mode;
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Country { get; set; }
        public string ContactInfo { get; set; }
        public string ImagePath { get; set; }
        public Person(int Id, string Name, DateTime BirthDate, string Country, string ContactInfo, string ImagePath)
        {
            this.Id = Id;
            this.Name = Name;
            this.BirthDate = BirthDate;
            this.Country = Country;
            this.ContactInfo = ContactInfo;
            this.ImagePath = ImagePath;

            _Mode = Mode.Update;
        }
        public Person()
        {
            this.Id = -1;
            this.Name = string.Empty;
            this.BirthDate = DateTime.MinValue;
            this.Country = string.Empty;
            this.ContactInfo = string.Empty;
            this.ImagePath = string.Empty;
        }
        private bool _Add()
        {
            this.Id = PersonData.Add(this.Name, this.BirthDate, this.Country, this.ContactInfo, this.ImagePath);
            return (Id != -1);

        }
        private bool _Update()
        {
            return PersonData.Update(this.Id, this.Name, this.BirthDate, this.Country, this.ContactInfo, this.ImagePath);
        }
        static public bool DeletePerson(int Id)
        {
            return PersonData.Delete(Id);
        }
        public bool Save()
        {
            switch (this._Mode)
            {
                case Mode.Add:
                    return _Add();
                case Mode.Update:
                    return _Update();
            }
            return false;
        }
        public static Person Find(int Id)
        {
            string Name = string.Empty;
            DateTime BirthDate = DateTime.MinValue;
            string Country = string.Empty;

            string ContactInfo = string.Empty;
            string ImagePath = string.Empty;

            if (PersonData.GetPersonById(Id, ref Name,
                ref BirthDate, ref Country, ref ContactInfo, ref ImagePath))
            {
                return new Person(Id, Name, BirthDate, Country, ContactInfo, ImagePath);
            }
            return null;
        }

        static public bool Exist(int Id)
        {
            return PersonData.Exist(Id);
        }


    }

}
