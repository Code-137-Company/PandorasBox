using Gtk;

namespace PandorasBox.Components
{
    public class PBButton : Button
    {
        public PBButton(string name) : base(name)
        {
            WidthRequest = 100;
            HeightRequest = 50;

            DefineProps();
        }

        public PBButton(string name, int width, int height) : base(name)
        {
            WidthRequest = width;
            HeightRequest = height;

            DefineProps();
        }

        private void DefineProps()
        {
            
        }
    }
}
