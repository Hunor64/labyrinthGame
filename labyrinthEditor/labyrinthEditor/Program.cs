using System.Resources;
using System.Globalization;
using labyrinthEditor.Functions;
using System.Text;

namespace labyrinthEditor;
class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        Map map = new Map();
        CursorMovement cursorMovement = new CursorMovement();
        Console.OutputEncoding = Encoding.UTF8;
        bool displayMenu = true;
        while (displayMenu)
        {
            Menu.DisplayMenu();
            displayMenu = false;
            switch (Console.ReadKey(true).KeyChar) {
                case '1':
                    Console.Write("\n" + Resources.strings.AskWidth + ": ");
                    int x = Int32.Parse(Console.ReadLine());
                    Console.Write("\n" + Resources.strings.AskHeight + ": ");
                    int y = Int32.Parse(Console.ReadLine());
                    map.CreateMap(y, x);
                    map.PrintMap();
                    cursorMovement.EnableCursorMovement(map);
                    break;
                case '2':
                    Console.WriteLine();
                    map.LoadMap("minta.txt");
                    map.PrintMap();
                    cursorMovement.EnableCursorMovement(map);
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
