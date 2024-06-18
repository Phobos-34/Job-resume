using TaxiBusiness.Services;

namespace TaxiClient
{
    public partial class AddNewDriverForm : Form
    {
        private DriverServiceForm _driverServiceForm;
        public AddNewDriverForm(DriverServiceForm driverServiceForm)
        {
            InitializeComponent();

            _driverServiceForm = driverServiceForm;
        }

        private void AddDriverBtn_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                DebugText.Text = "Name is incorrect";
                return;
            }
            string id = IDTextBox.Text;
            if (string.IsNullOrWhiteSpace(id))
            {
                DebugText.Text = "ID is incorrect";
                return;
            }

            MainService.GetDriverService().Add(name, int.Parse(id));
            _driverServiceForm.Show();
            Close();
        }

        private void AddNewDriverForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _driverServiceForm.Show();
        }
    }
}
