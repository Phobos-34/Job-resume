using TaxiBusiness.Services;
using TaxiData.Models;

namespace TaxiClient
{
    public partial class DriverServiceForm : Form
    {
        private AdminForm _adminForm;
        public DriverServiceForm(AdminForm adminForm)
        {
            InitializeComponent();

            _adminForm = adminForm;

            UpdateDriverListView();
        }

        private void UpdateDriverListView()
        {
            foreach (var driver in MainService.GetDriverService().Drivers)
            {
                ListViewItem item = new ListViewItem(driver.RegistrationCard.Id.ToString());
                item.SubItems.Add(driver.RegistrationCard.Name);
                DriverListView.Items.Add(item);
            }
        }

        private void AddDriverBtn_Click(object sender, EventArgs e)
        {
            AddNewDriverForm addNewDriverForm = new AddNewDriverForm(this);
            addNewDriverForm.Show();
            Hide();
        }

        private void DriverServiceForm_Activated(object sender, EventArgs e)
        {
            DriverListView.Items.Clear();
            UpdateDriverListView();
        }

        private void DriverServiceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _adminForm.Show();
        }

        private void DriverListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DriverListView.SelectedItems.Count == 0)
            {
                return;
            }

            Driver selectedDriver = MainService.GetDriverService().GetDriver(int.Parse(DriverListView.SelectedItems[0].Text));
            EditDriverForm editDriverForm = new EditDriverForm(selectedDriver, this);
            editDriverForm.Show();
            Hide();
        }
    }
}
