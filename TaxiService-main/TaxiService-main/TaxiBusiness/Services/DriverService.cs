using System.Diagnostics;
using TaxiData.Models;

namespace TaxiBusiness.Services
{
    public class DriverService : IService<List<Driver>>
    {
        private List<Driver> _drivers;

        public DriverService()
        {
            _drivers = Download();
        }

        public IReadOnlyCollection<Driver> Drivers => _drivers;
        public List<Driver> Download()
        {
            return MainService.GetJsonStorage().GetDrivers() ?? new List<Driver>();
        }

        public void Upload()
        {
            MainService.GetJsonStorage().Save(_drivers);
        }

        public void Add(string name, int regCardid)
        {
            RegistrationCard regCard = new RegistrationCard(name, regCardid);
            _drivers.Add(new Driver(regCard, MainService.GetIdGeneratorService().IdGenerator.GenerateDriverId()));
        }

        public void Remove(Driver driver)
        {
            _drivers.Remove(driver);
        }

        public void Edit(int id, string name, int regCardId)
        {
            var targetDriver = _drivers.Find(driver => driver.Id == id);


            if (targetDriver is not null)
            {
                targetDriver.RegistrationCard.SetName(name);
                targetDriver.RegistrationCard.SetId(regCardId);
            }
            else
            {
                throw new ArgumentException($"[-] There is not driver with id {id}");
            }
        }

        public Driver GetDriver(int id)
        {
            var res = _drivers.Find(driver => driver.RegistrationCard.Id.Equals(id));
            if (res is null)
            {
                throw new ArgumentException("[-] There is not id in the database");
            }
            return res;
        }

        public Driver GetDriver(string name)
        {
            Debug.Write(name);
            var res = _drivers.Find(driver => driver.RegistrationCard.Name.Equals(name));
            if (res is null)
            {
                throw new ArgumentException("[-] There is not id in the database");
            }
            return res;
        }
    }
}
