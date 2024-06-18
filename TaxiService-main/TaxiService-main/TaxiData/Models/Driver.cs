namespace TaxiData.Models
{
    public class Driver
    {
        private Car? _car;

        public Driver(RegistrationCard registrationCard, int id)
        {
            RegistrationCard = registrationCard;
            Id = id; 
        }

        public int Id { get; private set; }
        public RegistrationCard RegistrationCard { get; private set; }

        public void AddCar(Car car)
        {
            _car = car;
        }
    }
}
