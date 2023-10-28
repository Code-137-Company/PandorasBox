using Gtk;

namespace PandorasBox.Components
{
    public class PBWindow : Window
    {
        public PBWindow(string title) : base(title)
        {
            WidthRequest = 500;
            HeightRequest = 500;

            DefineProps();
        }

        public PBWindow(string title, int width, int height) : base(title)
        {
            WidthRequest = width;
            HeightRequest = height;

            DefineProps();
        }

        private void DefineProps()
        {
            Resizable = false;

            DeleteEvent += delegate { Application.Quit(); };
        }
    }
}
