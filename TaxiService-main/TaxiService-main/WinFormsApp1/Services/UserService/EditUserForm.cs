using TaxiBusiness.Services;
using TaxiData.Entities;
using TaxiData.Models;

namespace TaxiClient
{
    public partial class EditUserForm : Form
    {
        private User _currentUser;
        private UserServiceForm _userServiceForm;
        public EditUserForm(User user, UserServiceForm userServiceForm)
        {
            InitializeComponent();
            _currentUser = user;

            LoginTextBox.Text = user.Login;
            PasswordTextBox.Text = user.Password;
            UserTypeComboBox.Items.AddRange(new string[] { "Admin", "Dispatcher" });
            UserTypeComboBox.SelectedIndex = (int)user.Status;

            _userServiceForm = userServiceForm;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string userTypeStr = UserTypeComboBox.Text;
            UserType userType = UserType.Admin;
            switch (userTypeStr)
            {
                case "Dispatcher":
                    userType = UserType.Dispatcher;
                    break;
            }
            MainService.GetUserService().EditUser(_currentUser.Id, LoginTextBox.Text, PasswordTextBox.Text, userType);
            _userServiceForm.Show();
            Close();
        }

        private void EditUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _userServiceForm.Show();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            MainService.GetUserService().RemoveUser(_currentUser);
            _userServiceForm.Show();
            Close();
        }
    }
}
