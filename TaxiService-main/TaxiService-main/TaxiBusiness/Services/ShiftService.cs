using System.Diagnostics;
using TaxiData.Entities;
using TaxiData.Models;

namespace TaxiBusiness.Services
{
    public class ShiftService : IService<Shift>
    {
        private Shift _shift;

        public ShiftService()
        {
            _shift = Download();
            Debug.WriteLine("Shift " + _shift.Dispatcher);
        }

        public Shift Shift => _shift;
        public Shift Download()
        {
            Debug.WriteLine("-------DOWNLOAD----------");
            return MainService.GetJsonStorage().GetShift() ?? new Shift(null, null);
        }

        public void Upload()
        {
            Debug.WriteLine("-------SAVE----------");
            MainService.GetJsonStorage().Save(_shift);
        }

        public void Set(Shift shitf)
        {
            ClearShift();
            _shift = shitf;
        }

        public void ClearShift()
        {
            _shift.ClearShift();
        }
    }
}
