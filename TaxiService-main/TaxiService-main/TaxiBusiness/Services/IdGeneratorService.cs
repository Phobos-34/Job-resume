using TaxiData.Models;

namespace TaxiBusiness.Services
{
    public class IdGeneratorService : IService<IdGenerator>
    {
        public IdGeneratorService()
        {
            IdGenerator = Download();
        }

        public IdGenerator IdGenerator { get; private set; }

        public IdGenerator Download()
        {
            return MainService.GetJsonStorage().GetIdGenerator() ?? new IdGenerator();
        }

        public void Upload()
        {
            MainService.GetJsonStorage().Save(IdGenerator);
        }
    }
}
