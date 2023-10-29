using PandorasBox.Components;
using PandorasBox.Domain.Enums;
using PandorasBox.Service.Services.Interfaces;

namespace PandorasBox
{
    public class App
    {
        private IDashboardService _dashboard;

        public App(IDashboardService dashboard)
        {
            _dashboard = dashboard;
        }

        public void Run()
        {
            var console = new ConsoleInteration();

            while (true)
            {
                var result = console.Select<SelectOptionsEnum>("Select Option");

                switch (result)
                {
                    case SelectOptionsEnum.PowerLed:
                        _dashboard.PowerLed();
                        break;

                    case SelectOptionsEnum.AllReles:
                        _dashboard.AllReles();
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
