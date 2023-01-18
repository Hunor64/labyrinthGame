using System.Resources;
using System.Globalization;
using labyrinthEditor.Functions;

namespace labyrinthEditor;
class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        bool displayMenu = true;
        while (displayMenu)
        {
            Menu.DisplayMenu();
            displayMenu = false;
            switch (Console.ReadKey().KeyChar) {
                case '1':
                    Console.WriteLine("1");
                    break;
                case '2':
                    Console.WriteLine("2");
                    break;
                case '3':
                    Console.WriteLine("3");
                    break;
                case '4':
                    Console.WriteLine("4");
                    break;
                case '5':
                    Environment.Exit(0);
                    break;
            }
            Console.ReadKey();
        }
    }

}
