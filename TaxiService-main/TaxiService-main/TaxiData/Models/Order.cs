namespace TaxiData.Models
{
    public class Order
    {
        public Order(Driver driver, string clientName, int id)
        {
            Driver = driver;
            Id = id;
            ClientName = clientName;
            OrderStatus = OrderStatusEnum.Accepted;
        }

        public int Id { get; private set; }
        public OrderStatusEnum OrderStatus { get; private set; }
        public Driver Driver { get; private set; }
        public string? Satisfaction { get; private set; }
        public string ClientName { get; private set; }

        public void SetStatus(OrderStatusEnum orderStatus)
        {
            OrderStatus = orderStatus;
        }
    }
}
