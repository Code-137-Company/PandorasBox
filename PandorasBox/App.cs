using PandorasBox.Components;
using PandorasBox.Service.Services.Interfaces;
using Spectre.Console;

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
            var t = new ConsoleInteration();

            var test = t.Select("Testing", new[]
            {
                "Test 1",
                "Test 2",
                "Test 3",
                "Test 4",
                "Test 5",
                "Test 6",
                "Test 7",
                "Test 8",
                "Test 9",
                "Test 10",
                "Test 11",
                "Test 12",
                "Test 13",
            });

            Console.WriteLine(test);
            Console.ReadKey();
        }
    }
}
