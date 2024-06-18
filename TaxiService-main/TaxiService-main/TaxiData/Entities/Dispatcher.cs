using TaxiData.Models;

namespace TaxiData.Entities
{
    public class Dispatcher : User
    {
        public Dispatcher(string login, string password, int id) : base(login, password, UserType.Dispatcher, id)
        {
        }
    }
}
