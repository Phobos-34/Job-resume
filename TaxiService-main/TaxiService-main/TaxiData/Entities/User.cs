using System.Diagnostics;
using TaxiData.Models;

namespace TaxiData.Entities
{
    public class User
    {
        public User(string login, string password, UserType userType, int id)
        {
            Login = login;
            Password = password;
            Status = Status.Hired;
            UserType = userType;
            Id = id;
        }

        public int Id { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public Status Status { get; private set; }
        public UserType UserType { get; private set; }

        public void EditUser(string login, string password, UserType userType)
        {
            Login = login;
            Password = password;
            UserType = userType;
        }
    }
}

