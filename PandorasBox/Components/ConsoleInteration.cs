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

        public T Select<T>(string title) where T : Enum
        {
            var selection = new SelectionPrompt<string>()
                .Title(title)
                .PageSize(10)
                .MoreChoicesText("Move up and down to reveal more options")
                .AddChoices(Enum.GetNames(typeof(T)));

            var result = AnsiConsole.Prompt(selection);

            return (T)Enum.Parse(typeof(T), result);
        }
    }
}
