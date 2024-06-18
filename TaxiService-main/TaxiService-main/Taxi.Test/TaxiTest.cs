using TaxiBusiness.Services;
using TaxiData.Entities;

namespace Taxi.Test
{
    public class Tests
    {
        [Test]
        public void AddUser_UserAdded()
        {
            UserService userService = new UserService();
            userService.AddUser("321", "123", TaxiData.Models.UserType.Admin);
            User user1 = new User("321", "123", TaxiData.Models.UserType.Admin, 2);
            //Assert.Contains(userService.CheckUser(user1));
        }
    }
}