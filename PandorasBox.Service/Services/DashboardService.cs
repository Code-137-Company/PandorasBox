using PandorasBox.Service.Services.Interfaces;

namespace PandorasBox.Service.Services
{
    public class DashboardService : IDashboardService
    {
        private readonly SerialService _serial;

        public DashboardService(SerialService serialService)
        {
            _serial = serialService;
        }

        public void PowerLed()
        {
            _serial.Send("LED", out string error);
        }

        public void AllReles()
        {
            _serial.Send("ALL", out string error);
        }
    }
}
