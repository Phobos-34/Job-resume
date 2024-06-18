using System.Drawing;

namespace TaxiData.Models
{
    public class Car
    {
        public Car(CarColor color, string model, string vin, int id)
        {
            Color = color;
            Model = model;
            Id = id;
            Vin = vin;
        }

        public int Id { get; private set; }
        public CarColor Color { get; private set; }
        public string Model { get; private set; }
        public string Vin { get; private set; }

        public void SetModel(string model)
        {
            Model = model;
        }

        public void SetColor(CarColor color)
        {
            Color = color;
        }

        public void SetVin(string vin)
        {
            Vin = vin;
        }

        //public class VIN
        //{
        //    public string Value { get; private set;}

        //    public VIN(string value)
        //    {
        //        if(value.Length != 6)
        //        {
        //            return;
        //        }

        //        if (char.IsLetter(value[0])&&
        //            char.IsDigit(value[1])&&
        //            char.IsDigit(value[2])&&
        //            char.IsDigit(value[3]) &&
        //            char.IsLetter(value[4]) &&
        //            char.IsLetter(value[5]))
        //        {
        //            Value = value;
        //        }
        //        else
        //        {
        //            throw new ArgumentException("[-] Invalid VIN");
        //        }
        //    }

        //    public override string ToString()
        //    {
        //        return Value;
        //    }

        //}
    }

}
