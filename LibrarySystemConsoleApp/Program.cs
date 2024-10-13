using LibrarySystemBusiness;
using System;
namespace LibrarySystemConsoleApp
{

    public class Parent
    {
        public virtual int Id { get; set; } = 10;


        public void ChangeIdValue(int newId)
        {
            this.Id = newId;
        }
    }

    public class Child : Parent
    {
        public new int Id { get; set; } = 5;

        public void PrintId()
        {
            Console.WriteLine("before changing:");
            Console.WriteLine($"ParentId: {base.Id}");
            Console.WriteLine($"ChildId: {this.Id}");

            base.ChangeIdValue(5000);
            //  base.Id = 5000;

            Console.WriteLine("\n\nafter changing:");
            Console.WriteLine($"ParentId: {base.Id}");
            Console.WriteLine($"ChildId: {this.Id}");
        }

        /*
         *The result Using base.ChangeIdValue(5000);*
         before changing:
ParentId: 10
ChildId: 5


after changing:
ParentId: 10
ChildId: 5000

        *The result Using base.Id = 5000;*
        before changing:
ParentId: 10
ChildId: 5


after changing:
ParentId: 5000
ChildId: 5
         */
    }

    internal class Program
    {

        //static public void TestFind(int Lib)
        //{
        //    Customer customer = Customer.FindByLibraryCard(Lib);
        //    if (customer != null)
        //    {
        //        Console.WriteLine(customer.Id);
        //        Console.WriteLine(customer.Name);
        //        Console.WriteLine(customer.LibraryCardNumber);
        //        Console.WriteLine(customer.ContactInfo);
        //        Console.WriteLine(customer.PersonId);
        //        Console.WriteLine(customer.BirthDate);
        //        Console.WriteLine(customer.Country);
        //        Console.WriteLine(customer.ImagePath);
        //        Console.WriteLine(customer.IsAuthor);
        //        Console.WriteLine(customer.IsCustomer);
        //        Console.WriteLine(customer.IsUser);
        //    }
        //    else
        //    {
        //        Console.WriteLine("There is no");
        //    }
        //}

        //static public void TestAdd()
        //{
        //    Customer customer = new Customer();
        //    customer.Name = "Reem";
        //    customer.BirthDate = DateTime.Now;
        //    customer.Country = "Syria";
        //    customer.IsAuthor = false;
        //    customer.IsCustomer = true;
        //    customer.IsUser = false;
        //    customer.ContactInfo = "45464";
        //    customer.ImagePath = string.Empty;
        //    customer.LibraryCardNumber = 25;
        //    // customer.PersonId = 23;
        //    if (customer.Save())
        //    {
        //        Console.WriteLine("Success");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Failed");
        //    }
        //}

        //static public void TestUpdate(int LibNUM)
        //{
        //    Customer customer = Customer.FindByLibraryCard(LibNUM);
        //    customer.Name = "Reem";

        //    if (customer.Save())
        //    {
        //        Console.WriteLine("Success");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Failed");
        //    }
        //}
        //static public void TestDelete(int id)
        //{

        //    if (Customer.Delete(id))
        //    {
        //        Console.WriteLine("Success");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Failed");
        //    }
        //}

        //static public void TestAddAut()
        //{
        //    Author author = new Author();
        //    author.Name = "Roaaaa";
        //    author.BirthDate = DateTime.Now;
        //    author.Country = "Syria";
        //    author.IsAuthor = false;
        //    author.IsCustomer = true;
        //    author.IsUser = false;
        //    author.ContactInfo = "45464";
        //    author.ImagePath = string.Empty;
        //    author.Certificate = "fjss";
        //    author.AdditionalDetails = string.Empty;


        //    if (author.Save())
        //    {
        //        Console.WriteLine("Success");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Failed");
        //    }
        //}

        //static public void TestUpdateAuth(int id)
        //{

        //    Author author = Author.FindByLibraryCard(id);
        //    author.Name = "Lolo";

        //    if (author.Save())
        //    {
        //        Console.WriteLine("Success");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Failed");
        //    }
        //}

        //static public void TestDeleteA(int id)
        //{

        //    if (Author.Delete(id))
        //    {
        //        Console.WriteLine("Success");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Failed");
        //    }
        //}

        //static public void TestAddUs()
        //{
        //    User user = new User();
        //    user.Name = "Roaaaa";
        //    user.BirthDate = DateTime.Now;
        //    user.Country = "Syria";
        //    user.IsAuthor = false;
        //    user.IsCustomer = true;
        //    user.IsUser = false;
        //    user.ContactInfo = "45464";
        //    user.ImagePath = string.Empty;
        //    user.UserName = "User3";
        //    user.Password = "sjfjs";
        //    user.Permission = 8;


        //    if (user.Save())
        //    {
        //        Console.WriteLine("Success");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Failed");
        //    }
        //}

        //static public void TestDeleteUse(int id)
        //{

        //    if (User.Delete(id))
        //    {
        //        Console.WriteLine("Success");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Failed");
        //    }
        //}

        //static public void TestFindUser(string UserName)
        //{
        //    User user = User.FindByLibraryCard(UserName);
        //    if (user != null)
        //    {
        //        Console.WriteLine(user.Id);
        //        Console.WriteLine(user.Name);
        //        Console.WriteLine(user.UserName);
        //        Console.WriteLine(user.ContactInfo);
        //        Console.WriteLine(user.PersonId);
        //        Console.WriteLine(user.BirthDate);
        //        Console.WriteLine(user.Country);
        //        Console.WriteLine(user.ImagePath);
        //        Console.WriteLine(user.IsAuthor);
        //        Console.WriteLine(user.IsCustomer);
        //        Console.WriteLine(user.IsUser);
        //        Console.WriteLine(user.Permission);
        //        Console.WriteLine(user.Password);

        //    }
        //    else
        //    {
        //        Console.WriteLine("There is no");
        //    }
        //}

        //...


        static void Main(string[] args)
        {

            //Fine f = new Fine(27, 5);
            //f.Amount = 500;
            //f.NumberOfLateDays = 12;
            //f.PaymentStatus = true;
            //if (f.Save())
            //{
            //    Console.WriteLine("Yde");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}



            Fine f1 = Fine.Find(2);
            Console.WriteLine(f1.Id);
            Console.WriteLine(f1.CustomerId);
            Console.WriteLine(f1.BorrowingRecordId);
            Console.WriteLine(f1.Amount);
            Console.WriteLine(f1.NumberOfLateDays);
            Console.WriteLine(f1.PaymentStatus);


            //BorrowingRecord borrowingRecord = new BorrowingRecord(1, 27);
            //borrowingRecord.BorrowingDate = new DateTime(2001, 4, 1);
            //borrowingRecord.DueDate = new DateTime(2001, 5, 1);
            //borrowingRecord.ActualReturnDate = new DateTime(2001, 4, 25);



            //if (borrowingRecord.Save())
            //{
            //    Console.WriteLine("Yde");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}
            // BorrowingRecord.Delete(6);
            //BorrowingRecord b = BorrowingRecord.Find(5);
            //b.DueDate = new DateTime(2001, 4, 26);
            //b.Save();
            //Console.WriteLine(b.DueDate);
            if (BorrowingRecord.Exist(10))
            {
                Console.WriteLine("Y");
            }



            //BookCopy bookCopy = new BookCopy(2);
            //Console.WriteLine(bookCopy.Book.Title);

            //if (BookCopy.Exist(2))
            //{
            //    Console.WriteLine("Yde");
            //}


            //    Book book = new Book(1);
            //    book.Title = "Time";
            //    book.ISBN = "4789646";
            //    book.Genre = "s";
            //    book.AdditionalDetails = string.Empty;
            //    book.BorrowingPrice = 4;
            //    book.ImagePath = string.Empty;
            //    book.NumberOfPages = 4;
            //    book.PublicationDate = 2022;
            //    book.PublishingHouse = string.Empty;
            //    if (book.Save())
            //    {
            //        Console.WriteLine("Yes");
            //    }
            //    else
            //    {
            //        Console.WriteLine("NO");
            //    }

            //Book book1 = Book.FindByLibraryCard(2);
            //Console.WriteLine(book1.Author.Person.Name);


            //if (Book.Exist(10))
            //{
            //    Console.WriteLine("ys");
            //}


            //Person person = new Person();
            //person.Name = "Test";
            //person.ContactInfo = "ksf";
            //person.ImagePath = string.Empty;
            //person.Country = "Syria";
            //person.BirthDate = DateTime.Now;
            //person.Save();

            //Customer customer = new Customer(52);
            //customer.LibraryCardNumber = 80;
            //customer.Save();

            // Console.WriteLine(customer.Person.Name);

            //User user = new User(52);
            //user.Permission = 5;
            //user.UserName = "UserTest";
            //user.Password = "sf";
            //user.Save();

            //Console.WriteLine(user.Person.Name);

            //Author author = new Author(52);
            //author.Certificate = string.Empty;
            //author.AdditionalDetails = string.Empty;
            //author.Save();
            //Console.WriteLine(author.Person.Name);


            //Parent parent = new Parent() { Id = 2 };
            //Child child = new Child();
            //child.PrintId();

            //Console.WriteLine("before changing:");
            //Console.WriteLine($"ParentId: {parent.Id}");
            //Console.WriteLine($"ChildId: {child.Id}");

            //parent.Id = 50;

            //Console.WriteLine("\n\nafter changing:");
            //Console.WriteLine($"ParentId: {parent.Id}");
            //Console.WriteLine($"ChildId: {child.Id}");

            //TestAdd();
            //TestDeleteA(7);
            //TestUpdateAuth(7);
            // TestAddAut();
            //TestAddUs();

            //  TestDeleteUse(7);

            //TestFindUser("User1");

            //TestDelete(5);
            // TestUpdate(3);
            // TestAdd();
            // PersonData.Add("ahmad", DateTime.Now, "Amman", false, true, false, "45665", null);
            //if (PersonData.Delete(22))
            //{
            //    Console.WriteLine("Success");
            //}
            //if (PersonData.Update(23, "ahmad", DateTime.Now, "Amman", false, true, false, "45665", null))
            //{
            //    Console.WriteLine("Success");
            //}
            //else
            //{
            //    Console.WriteLine("Failed");
            //}

            // CustomerData.Add(5, 19);
            //if (CustomerData.Update(7, 6, 19))
            //{
            //    Console.WriteLine("Success");
            //}
            //else
            //{
            //    Console.WriteLine("Failed");
            //}

            //CustomerData.Delete(7);
            // UserData.Add("User8", "kslj", 2, 1);
            //UserData.Update(1, "Roaa", "dfs", 2, 1);
            // UserData.Delete
            //  AuthorData.Add("ejiej", 23, "jshs");
            //AuthorData.Update(6, "HI", 23, "hsks");
            // AuthorData.Delete(6);



            Console.ReadKey();


        }
    }
}
