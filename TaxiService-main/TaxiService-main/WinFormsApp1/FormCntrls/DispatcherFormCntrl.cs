using TaxiData.Entities;
using TaxiData.Models;

namespace TaxiClient.FormCntrls
{
    public class DispatcherFormCntrl
    {
        private User _user;
        public DispatcherFormCntrl(User user)
        {
            _user = user;
        }

        public string GetLogin()
        {
            return _user.Login;
        }

        public string GetUserType()
        {
            switch (_user.UserType)
            {
                case UserType.Admin:
                    return "Admin";
                case UserType.Dispatcher:
                    return "Dispatcher";
                default:
                    return "I don't understand";
            }
        }
    }
}
