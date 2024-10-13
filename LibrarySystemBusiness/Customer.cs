using LibrarySystemDataAccess;
using System.Data;
namespace LibrarySystemBusiness
{
    public class Customer
    {

        public Person Person { get; private set; }
        private enum ModeCustomer { Add, Update };
        ModeCustomer _Mode;
        public int Id { get; set; }
        public string LibraryCardNumber { get; set; }
        public int PersonId { get; set; }

        public Customer()
        {
            Person Person = new Person();
            this.Id = -1;
            this.LibraryCardNumber = string.Empty;
            this.PersonId = PersonId;
            _Mode = ModeCustomer.Add;
        }
        private Customer(int Id, string LibraryCardNumber, int PersonId)
        {
            Person = Person.Find(PersonId);
            this.Id = Id;
            this.LibraryCardNumber = LibraryCardNumber;
            this.PersonId = PersonId;
            _Mode = ModeCustomer.Update;
        }
        private bool _Add()
        {//validation
            this.Id = CustomerData.Add(this.LibraryCardNumber, this.PersonId);
            return (Id != -1);
        }
        private bool _Update()
        {
            //validatioin
            return CustomerData.Update(this.Id, this.LibraryCardNumber, this.PersonId);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case ModeCustomer.Add:
                    return _Add();
                case ModeCustomer.Update:
                    return _Update();
            }
            return false;

        }
        public static bool Delete(int LibraryCardNum)
        {
            return CustomerData.Delete(LibraryCardNum);
        }

        public static DataTable All()
        {
            return CustomerData.All();
        }

        public static Customer FindByLibraryCard(string LibraryCardNumber)
        {
            int Id = -1;
            int PersonId = -1;

            if (CustomerData.GetCustomerByCard(LibraryCardNumber, ref Id, ref PersonId))

            {
                return new Customer(Id, LibraryCardNumber, PersonId);

            }
            return null;
        }

        public static Customer Find(int Id)
        {
            string LibraryCardNumber = string.Empty;
            int PersonId = -1;

            if (CustomerData.GetCustomerById(Id, ref LibraryCardNumber, ref PersonId))
            {
                return new Customer(Id, LibraryCardNumber, PersonId);

            }
            return null;
        }
        static public bool Exist(int Id)
        {
            return CustomerData.Exist(Id);
        }


    }
}
