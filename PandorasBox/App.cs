using PandorasBox.Components;
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
            var c = new ConsoleInteration();

            c.Select("Test", new[]
            {
                "Test 1",
                "Test 2",
                "Test 3",
                "Test 4",
                "Test 5",
            });

            Console.ReadKey();
        }
    }
}
