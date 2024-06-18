using TaxiBusiness.Services;
using TaxiData.Entities;
using TaxiData.Models;
using WinFormsApp1;

namespace TaxiClient.FormCntrls
{
    public class MainFormCntrl
    {
        public User? Authentication(string login, string password)
        {
            return MainService.GetUserService().FindUser(login, password);
        }
        public void Authorization(User user, MainForm mainForm)
        {
            switch (user.UserType)
            {
                case UserType.Admin:
                    AdminForm adminForm = new AdminForm(user, mainForm);
                    adminForm.Show();
                    break;
                case UserType.Dispatcher:
                    DispatcherForm dispatcherForm = new DispatcherForm(user, mainForm);
                    dispatcherForm.Show();
                    break;
                default:
                    break;
            }
        }
    }
}
