
namespace TaxiData.Models
{
    public static class ColorSetter
    {
        public static CarColor WhatColor(string color)
        {
            switch(color)
            {
                case "White":
                    return CarColor.White;
                case "Black":
                    return CarColor.Black;
                case "Silver":
                    return CarColor.Silver;
                case "Yellow":
                    return CarColor.Yellow;
                case "Blue":
                    return CarColor.Blue;
                case "Red":
                    return CarColor.Red;
                case "Green":
                    return CarColor.Green;
                default:
                    throw new ArgumentException("[-] Invalid color");

            }
        }
    }
}
