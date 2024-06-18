
using TaxiBusiness.Services;
using TaxiData.Models;

namespace TaxiClient.Services.CarService
{
    public partial class CarServiceForm : Form
    {
        private AdminForm _adminForm;
        public CarServiceForm(AdminForm adminForm)
        {
            InitializeComponent();

            _adminForm = adminForm;
            UpdateCarListView();
        }

        private void UpdateCarListView()
        {
            foreach (var car in MainService.GetCarService().Cars)
            {
                ListViewItem item = new ListViewItem(car.Id.ToString());
                item.SubItems.Add(car.Color.ToString());
                item.SubItems.Add(car.Model);
                item.SubItems.Add(car.Vin.ToString());
                CarListView.Items.Add(item);
            }
        }

        private void AddCarBtn_Click(object sender, EventArgs e)
        {
            AddNewCarForm addNewCarForm = new AddNewCarForm(this);
            addNewCarForm.Show();
            Hide();
        }

        private void CarServiceForm_Activated(object sender, EventArgs e)
        {
            CarListView.Items.Clear();
            UpdateCarListView();
        }

        private void CarServiceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _adminForm.Show();
        }

        private void CarListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CarListView.SelectedItems.Count == 0)
            {
                return;
            }

            Car selectedCar = MainService.GetCarService().GetCar(int.Parse(CarListView.SelectedItems[0].Text));
            EditCarForm editCarForm = new EditCarForm(selectedCar, this);
            editCarForm.Show();
            Hide();
        }
    }
}
