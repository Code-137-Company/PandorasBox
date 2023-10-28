using Gtk;
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

        public void Build()
        {
            Application.Init();

            PBWindow window = new PBWindow("Pandoras Box", 500, 500);

            PBButton button = new PBButton("Click-me");
            button.Clicked += (sender, e) =>
            {
                _dashboard.PowerLed();
            };

            PBButton buttonTwo = new PBButton("Click-me");
            buttonTwo.Clicked += (sender, e) =>
            {
                _dashboard.AllReles();
            };

            PBFrame frame = new PBFrame("Teste");

            //frame.Add(button);
            frame.Add(buttonTwo);
            window.Add(frame);

            window.ShowAll();
        }

        public void Run() => Application.Run();
    }
}
