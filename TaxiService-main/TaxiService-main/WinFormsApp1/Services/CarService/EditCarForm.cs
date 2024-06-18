using TaxiBusiness.Services;
using TaxiData.Models;

namespace TaxiClient.Services.CarService
{
    public partial class EditCarForm : Form
    {
        private Car _currentCar;
        private CarServiceForm _carServiceForm;
        public EditCarForm(Car car, CarServiceForm carServiceForm)
        {
            InitializeComponent();
            _carServiceForm = carServiceForm;
            _currentCar = car;
            ColorComboBox.Items.AddRange(new string[] { "White", "Black", "Silver", "Yellow", "Blue", "Red", "Green" });

            ColorComboBox.SelectedIndex = (int)car.Color;
            ModelTextBox.Text = car.Model;
            VINTextBox.Text = car.Vin;
        }

        private void EditCarForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _carServiceForm.Show();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
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
                MainService.GetCarService().Edit(_currentCar.Id, color, model, vin);
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

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            MainService.GetCarService().RemoveCar(_currentCar);
            _carServiceForm.Show();
            Close();
        }
    }
}
