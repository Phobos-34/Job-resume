namespace TaxiData.Models
{
    public class IdGenerator
    {
        public int CurrentUserId;
        public int CurrentCarId;
        public int CurrentDriverId;
        public int CurrentOrderId;
        public int CurrentClientId;
        public int GenerateUserId()
        {
            return ++CurrentUserId;
        }

        public int GenerateCarId()
        {
            return ++CurrentCarId;
        }

        public int GenerateDriverId()
        {
            return ++CurrentDriverId;
        }

        public int GenerateOrderId()
        {
            return ++CurrentOrderId;
        }

        public int GenerateClientId()
        {
            return ++CurrentClientId;
        }
    }
}
