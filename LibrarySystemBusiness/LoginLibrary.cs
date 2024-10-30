using LibrarySystemDataAccess;
using System;
using System.Data;

namespace LibrarySystemBusiness
{
    public class LoginLibrary
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime LoginDate { get; set; }

        public DateTime LogoutDate { get; set; }

        public LoginLibrary()
        {
            this.Id = -1;
            this.LoginDate = DateTime.MinValue;
            this.LogoutDate = DateTime.MinValue;
            this.UserId = -1;
        }

        static public DataTable All()
        {
            return LoginData.All();
        }
        public bool Add()
        {
            this.Id = LoginData.Add(this.UserId, this.LoginDate, this.LogoutDate);
            return (this.Id != -1);
        }



    }
}
