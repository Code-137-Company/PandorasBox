using Spectre.Console;

namespace PandorasBox.Components
{
    public class ConsoleInteration
    {
        public ConsoleInteration()
        {

        }

        public T InputText<T>(string title)
        {
            return AnsiConsole.Ask<T>($"{title} > ");
        }

        public string Select(string title, string[] selections)
        {
            var selection = new SelectionPrompt<string>()
                .Title(title)
                .PageSize(10)
                .MoreChoicesText("Move up and down to reveal more options")
                .AddChoices(selections);

            return AnsiConsole.Prompt(selection);
        }
    }
}
