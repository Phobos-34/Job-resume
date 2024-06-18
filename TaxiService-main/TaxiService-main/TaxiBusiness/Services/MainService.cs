using TaxiData;

namespace TaxiBusiness.Services
{
    public static class MainService
    {
        private static UserService? _userService;
        private static OrderService? _orderService;
        private static IdGeneratorService? _idGeneratorService;
        private static JsonStorage? _jsonStorage;
        private static DriverService? _driverService;
        private static CarService? _carService;
        private static ShiftService? _shiftService;
        public static UserService GetUserService()
        {
            return _userService ??= new UserService();
        }
        public static OrderService GetOrderService()
        {
            return _orderService ??= new OrderService();
        }
        public static IdGeneratorService GetIdGeneratorService()
        {
            return _idGeneratorService ??= new IdGeneratorService();
        }
        public static JsonStorage GetJsonStorage()
        {
            return _jsonStorage ??= new JsonStorage();
        }
        public static DriverService GetDriverService()
        {
            return _driverService ??= new DriverService();
        }
        public static CarService GetCarService()
        {
            return _carService ??= new CarService();
        }
        public static ShiftService GetShiftService()
        {
            return _shiftService ??= new ShiftService();
        }
        public static void Upload()
        {
            GetUserService().Upload();
            GetOrderService().Upload();
            GetIdGeneratorService().Upload();
            GetDriverService().Upload();
            GetCarService().Upload();
            GetShiftService().Upload();
        }

        public static void Download()
        {
            GetUserService().Download();
            GetOrderService().Download();
            GetIdGeneratorService().Download();
            GetDriverService().Download();
            GetCarService().Download();
            GetShiftService().Download();
        }
    }
}
