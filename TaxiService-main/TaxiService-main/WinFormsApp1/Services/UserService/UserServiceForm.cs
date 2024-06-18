using TaxiBusiness.Services;
using TaxiData.Entities;

namespace TaxiClient
{
    public partial class UserServiceForm : Form
    {
        private AdminForm _adminForm;
        public UserServiceForm(AdminForm adminForm)
        {
            InitializeComponent();

            _adminForm = adminForm;

            UpdateUserListView();
        }

        private void UpdateUserListView()
        {
            foreach (var user in MainService.GetUserService().Users)
            {
                ListViewItem item = new ListViewItem(user.Id.ToString());
                item.SubItems.Add(user.Login);
                UserListView.Items.Add(item);
            }
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            AddNewUserForm addNewUserForm = new AddNewUserForm(this);
            addNewUserForm.Show();
            Hide();
        }

        private void UserServiceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _adminForm.Show();
        }

        private void UserListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserListView.SelectedItems.Count == 0)
            {
                return;
            }

            User selectedUser = MainService.GetUserService().GetUser(int.Parse(UserListView.SelectedItems[0].Text));
            EditUserForm editUserForm = new EditUserForm(selectedUser, this);
            editUserForm.Show();
            Hide();
        }

        private void UserServiceForm_Activated(object sender, EventArgs e)
        {
            UserListView.Items.Clear();
            UpdateUserListView();
        }
    }
}
