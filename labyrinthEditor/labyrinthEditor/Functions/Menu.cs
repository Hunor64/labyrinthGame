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
            Console.WriteLine("1. " + Resources.strings.MenuItemCreateMap);
            Console.WriteLine("2. " + Resources.strings.MenuItemLoadMap);
            Console.WriteLine("3. " + Resources.strings.ChangeLanguage);
            Console.WriteLine("4. " + Resources.strings.ExitMenu);
        }

        public static void MainMenu(Map map, CursorMovement cursorMovement) {
            bool displayMenu = true;
            while (displayMenu)
            {
                Console.BackgroundColor = ConsoleColor.Black;
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
                        Console.WriteLine(Resources.strings.EnterAbsolutePath);
                        string path = Console.ReadLine().Trim();
                        try {
                            File.Exists(path);
                            map.LoadMap(path);
                            map.PrintMap();
                            cursorMovement.EnableCursorMovement(map);
                        } catch {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(Resources.strings.Error_PathDoesntExist);
                            Console.WriteLine(Resources.strings.PressEnterToContinue);
                            Console.ForegroundColor = ConsoleColor.White;
                            if (Console.ReadKey().Key == ConsoleKey.Enter) {
                                MainMenu(map, cursorMovement);
                            }
                        }
                        
                        break;
                    case '3':
                        ChangeLanguage(map, cursorMovement);
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

        public static void ChangeLanguage(Map map, CursorMovement cursorMovement) {
            Console.Clear();
            Console.WriteLine("1. Hungarian/Magyar");
            Console.WriteLine("2. English");
            Console.WriteLine($"3. {Resources.strings.ReturnToMenu}");
            ConsoleKeyInfo input =  Console.ReadKey(true);

            switch (input.Key)
            {
                case ConsoleKey.D1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("hu-HU");
                    Menu.MainMenu(map, cursorMovement);    
                    break;
                case ConsoleKey.D2:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                    Menu.MainMenu(map, cursorMovement);
                    break;
                case ConsoleKey.D3:
                    Menu.MainMenu(map, cursorMovement);
                    break;
                default:
                    ChangeLanguage(map, cursorMovement);
                    break;
            }   
        }
    }
}
