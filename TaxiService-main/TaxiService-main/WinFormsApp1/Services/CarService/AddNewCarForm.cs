using Newtonsoft.Json.Linq;
using TaxiBusiness.Services;
using TaxiData.Models;

namespace TaxiClient.Services.CarService
{
    public partial class AddNewCarForm : Form
    {
        private CarServiceForm _carServiceForm;
        public AddNewCarForm(CarServiceForm carServiceForm)
        {
            InitializeComponent();
            _carServiceForm = carServiceForm;
            ColorComboBox.Items.AddRange(new string[] { "White", "Black", "Silver", "Yellow", "Blue", "Red", "Green" });
        }

        private void AddNewCarForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _carServiceForm.Show();
        }

        private void AddCarBtn_Click(object sender, EventArgs e)
        {
            var color = ColorSetter.WhatColor(ColorComboBox.Text.ToString());
            var model = ModelTextBox.Text;
            var vin = VINTextBox.Text;

            if (vin.Length != 6)
            {
                DebugText.Text = "Invalid VIN";
                return;
            }

            if (char.IsLetter(vin[0]) &&
                char.IsDigit(vin[1]) &&
                char.IsDigit(vin[2]) &&
                char.IsDigit(vin[3]) &&
                char.IsLetter(vin[4]) &&
                char.IsLetter(vin[5]))
            {
                MainService.GetCarService().AddCar(color, model, vin);
                _carServiceForm.Show();
                Close();
            }
            else
            {
                DebugText.Text = "Invalid VIN";
            }
        }

        private void VINTextBox_TextChanged(object sender, EventArgs e)
        {
            DebugText.Text = " ";
        }
    }
}
