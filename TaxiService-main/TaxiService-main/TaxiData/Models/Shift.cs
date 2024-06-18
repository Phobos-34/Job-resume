using System.Diagnostics;
using TaxiData.Entities;

namespace TaxiData.Models
{
    public class Shift
    {
        public User Dispatcher { get; private set; }
        public List<Driver> DriverList { get; private set; }

        public Shift(User? dispatcher, List<Driver>? driverList)
        {
            if(driverList is null)
            {
                DriverList = new List<Driver>();
            }
            else
            {
                DriverList = driverList;
            }
            Dispatcher = dispatcher;
        }

        public void ClearShift()
        {
            Dispatcher = null;
            DriverList.Clear();
        }

        public void SetDispatcher(User dispatcher)
        {
            Dispatcher = dispatcher;
        }

        public void AddDriver(Driver driver)
        {
            DriverList.Add(driver);
        }
    }
}
