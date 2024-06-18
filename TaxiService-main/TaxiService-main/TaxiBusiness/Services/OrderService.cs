using TaxiData.Models;

namespace TaxiBusiness.Services
{
    public class OrderService : IService<List<Order>>
    {
        private List<Order> _orders;

        public OrderService()
        {
            _orders = Download();
        }

        public IReadOnlyCollection<Order> Orders => _orders;
        public List<Order> Download()
        {
            return MainService.GetJsonStorage().GetOrders() ?? new List<Order>();
        }

        public void Upload()
        {
            MainService.GetJsonStorage().Save(_orders);
        }

        public void Add(Driver driver, string client)
        {
            _orders.Add(new Order(driver, client, MainService.GetIdGeneratorService().IdGenerator.GenerateOrderId()));
        }

    }
}
