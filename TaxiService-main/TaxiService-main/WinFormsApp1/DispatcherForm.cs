using TaxiBusiness.Services;
using TaxiClient.FormCntrls;
using TaxiClient.Services.OrderService;
using TaxiData.Entities;
using WinFormsApp1;

namespace TaxiClient
{
    public partial class DispatcherForm : Form
    {
        private User _currentUser;
        private MainForm _mainForm;
        public DispatcherForm(User user, MainForm mainForm)
        {
            InitializeComponent();

            DispatcherFormCntrl dispatcherFormCntrl = new DispatcherFormCntrl(user);

            LoginText.Text = dispatcherFormCntrl.GetLogin();
            RoleText.Text = dispatcherFormCntrl.GetUserType();
            _currentUser = user;
            _mainForm = mainForm;

            UpdateOrderListView();
        }

        private void DispatcherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.Show();
        }

        private void CreateOrderBtn_Click(object sender, EventArgs e)
        {
            CreateOrderForm createOrderForm = new CreateOrderForm(this);
            createOrderForm.Show();
            Hide();
        }

        private void UpdateOrderListView()
        {
            foreach (var order in MainService.GetOrderService().Orders)
            {
                ListViewItem item = new ListViewItem(order.Driver.RegistrationCard.Name);
                item.SubItems.Add(order.ClientName);
                item.SubItems.Add(order.Satisfaction);
                OrderListView.Items.Add(item);
            }
        }

        private void DispatcherForm_Activated(object sender, EventArgs e)
        {
            OrderListView.Items.Clear();
            UpdateOrderListView();
        }
    }
}
