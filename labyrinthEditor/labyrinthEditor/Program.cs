using System.Resources;
using System.Globalization;
using labyrinthEditor.Functions;

namespace labyrinthEditor;
class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        Map map = new Map();
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
                    map.LoadMap("minta.txt");
                    map.PrintMap();
                    break;
                case '3':
                    Console.WriteLine("3");
                    break;
                case '4':
                    Environment.Exit(0);
                    break;
                default:
                    displayMenu = true;
                    break;
            }
            Console.ReadKey();
        }
    }

}
