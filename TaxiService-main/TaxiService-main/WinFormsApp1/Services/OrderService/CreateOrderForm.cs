using TaxiBusiness.Services;

namespace TaxiClient.Services.OrderService
{
    public partial class CreateOrderForm : Form
    {
        private DispatcherForm _dispatcherForm;
        public CreateOrderForm(DispatcherForm dispatcherForm)
        {
            InitializeComponent();

            UpdateDriverComboBox();
            _dispatcherForm = dispatcherForm;
        }

        public void UpdateDriverComboBox()
        {
            foreach (var driver in MainService.GetDriverService().Drivers)
            {
                DriverComboBox.Items.Add(driver.RegistrationCard.Name.ToString());
            }
        }

        private void CreateOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _dispatcherForm.Show();
            Hide();
        }

        private void CreateOrderBtn_Click(object sender, EventArgs e)
        {
            var driver = MainService.GetDriverService().GetDriver(DriverComboBox.Text);
            var client = ClientTextBox.Text;
            MainService.GetOrderService().Add(driver, client);
            _dispatcherForm.Show();
            Close();
        }
    }
}