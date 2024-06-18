using TaxiData.Entities;
using TaxiData.Models;

namespace TaxiBusiness.Services
{
    public class UserService : IService<List<User>>
    {
        private List<User> _users;

        public UserService()
        {
            _users = Download();
            if (_users.Count == 0)
            {
                GenerateDefaultAdmin();
            }
        }
        public IReadOnlyCollection<User> Users => _users;

        public void AddUser(string login, string password, UserType userType)
        {
            _users.Add(new User(login, password, userType, MainService.GetIdGeneratorService().IdGenerator.GenerateUserId()));
        }

        public void RemoveUser(User user)
        {
            _users.Remove(user);
        }

        public void EditUser(int id, string login, string password, UserType userType)
        {
            var targetUser = _users.Find(user => user.Id == id);

            if(targetUser is not null)
            {
                targetUser.EditUser(login, password, userType);
            }
            else
            {
                throw new ArgumentException($"[-] There is not user with id {id}");
            }
        }

        public User? FindUser(string login, string password)
        {
            return _users.FirstOrDefault(user => user.Login.Equals(login) && user.Password.Equals(password));
        }

        public User? FindUser(string login)
        {
            return _users.FirstOrDefault(user => user.Login.Equals(login));
        }

        public User GetUser(int id)
        {
            var res = _users.Find(user => user.Id.Equals(id));
            if (res is null)
            {
                throw new ArgumentException("[-] There is not id in the database");
            }
            return res;
        }

        public List<User> Download()
        {
            return MainService.GetJsonStorage().GetUsers() ?? new List<User>();
        }

        public void Upload()
        {
            MainService.GetJsonStorage().Save(_users);
        }

        private void GenerateDefaultAdmin()
        {
            AddUser("root", "root", UserType.Admin);
        }
    }
}
