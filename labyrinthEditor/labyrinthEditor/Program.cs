using System.Resources;
using System.Globalization;

namespace labyrinthEditor;
class Program
{
    static void Main(string[] args)
    {
        DisplayMenu();
        Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("hu-HU"); //i18n testing
        DisplayMenu();
        Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US"); //i18n testing
        DisplayMenu();
    }

    static void DisplayMenu() {
        Console.WriteLine(Resources.strings.MenuTitle);
        Console.WriteLine("1. " + Resources.strings.MenuTitle);
        Console.WriteLine("2. " + Resources.strings.MenuItemCreateMap);
        Console.WriteLine("3. " + Resources.strings.MenuItemLoadMap);
        Console.WriteLine("4. " + Resources.strings.ChangeLanguage);
        Console.WriteLine("5. " + Resources.strings.ExitMenu);
    }
}
