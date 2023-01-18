using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labyrinthEditor.Functions
{
    internal class Menu
    {
        public static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine(Resources.strings.MenuTitle);
            Console.WriteLine("1. " + Resources.strings.MenuTitle);
            Console.WriteLine("2. " + Resources.strings.MenuItemCreateMap);
            Console.WriteLine("3. " + Resources.strings.MenuItemLoadMap);
            Console.WriteLine("4. " + Resources.strings.ChangeLanguage);
            Console.WriteLine("5. " + Resources.strings.ExitMenu);
        }
    }
}
