using System;
using System.IO;
using System.Linq;

namespace LabirintusJatek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Válasszon nyelvet! / Choose a Language:\n1. Magyar\n2. English");
            char userlanguage = Console.ReadKey().KeyChar;
            Console.Clear();
            if (userlanguage != '1' && userlanguage != '2')
            {
                userlanguage = '2';
            }
            char userChoise = '1';
            while (true)
            {
                Console.Clear();
                if (userlanguage == '1')
                {
                    Console.WriteLine("1. Játék gyors folytatása");
                    Console.WriteLine("2. Új pálya");
                    Console.WriteLine("3. Pálya betöltése");
                    Console.WriteLine("4. Pályaszerkeztő megnyitása");
                    Console.WriteLine("5. Nyelv változtatása / Change language");
                    Console.WriteLine("6. Kilépés");
                    userChoise = Console.ReadKey().KeyChar;
                }
                else if (userlanguage == '2')
                {
                    Console.WriteLine("1. Quick resume game");
                    Console.WriteLine("2. New game");
                    Console.WriteLine("3. Load game");
                    Console.WriteLine("4. Open map editor");
                    Console.WriteLine("5. Change language / Nyelv változtatása");
                    Console.WriteLine("6. Quit game");
                    userChoise = Console.ReadKey().KeyChar;
                }
                string filePath = "map.txt";
                switch (userChoise)
                {
                    case '1':
                        Console.Clear();
                        if (File.Exists("map.txt"))
                        {
                            LaunchGame("map.txt",userlanguage);
                        }
                        else
                        {
                            Console.WriteLine("Még nincs mentésed!");
                        }
                        break;

                    case '2':
                        Console.Clear();

                        break;

                    case '3':
                        Console.Clear();
                        if (userlanguage == '1')
                        {
                            Console.Write("Adja meg a pálya helyét: ");
                            filePath = Console.ReadLine();
                        }
                        if (filePath.StartsWith('"') && filePath.EndsWith('"'))
                        {
                            filePath = filePath.Substring(1, filePath.Length - 2);
                        }

                        if (File.Exists(filePath))
                        {
                            LaunchGame(filePath,userlanguage);
                        }
                        else
                        {
                            Console.WriteLine("Error!");
                        }
                        break;

                    case '4':
                        Console.Clear();

                        break;

                    case '5':
                        Console.Clear();
                        Console.WriteLine("Válasszon nyelvet! / Choose a Language:\n1. Magyar\n2. English");
                        userlanguage = Console.ReadKey().KeyChar;
                        Console.Clear();
                        break;
                }
                if (userChoise == '6')
                {
                    break;
                }

            }
        }

        static void LaunchGame(string filePath, char userlanguage)
        {
            char[,] map;
            bool canEscape = false;
            int userMoves = 0;
            string[] lines = File.ReadAllLines(filePath);
            map = new char[lines.Count(), lines[0].Count()];
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < lines.Count(); i++)
            {
                for (int k = 0; k < lines[0].Count(); k++)
                {
                    map[i, k] = lines[i][k];
                }
            }
            bool roomReached = false;
            int ymax = map.GetLength(0); ;
            int xmax = map.GetLength(1);
            int x = 0;
            int y = 0;
            Console.Clear();
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int k = 0; k < map.GetLength(1); k++)
                {
                    Console.Write(map[i, k]);
                }
                Console.WriteLine("");
            }
            while (true)
            {
                if (map[y, x] == '.')
                {
                    y++;
                }
                if (map[y, x] != '.')
                {
                    break;
                }
            }
            Console.SetCursorPosition(x, y);
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Write(map[y, x]);
                Console.BackgroundColor = ConsoleColor.Black;
                char userMove = Console.ReadKey().KeyChar;
                if (userMove == 'w' && y > 0 && map[y - 1, x] != '.')
                {
                    if (map[y - 1, x] == '╬' || map[y - 1, x] == '╦' || map[y - 1, x] == '║' || map[y - 1, x] == '╣' || map[y - 1, x] == '╠' || map[y - 1, x] == '╗' || map[y - 1, x] == '╔' || map[y - 1, x] == '█')
                    {
                        y--;
                        userMoves++;

                    }


                }
                else if (userMove == 's' && y + 1 < ymax && map[y + 1, x] != '.')
                {
                    if (map[y + 1, x] == '╬' || map[y + 1, x] == '╩' || map[y + 1, x] == '║' || map[y + 1, x] == '╣' || map[y + 1, x] == '╠' || map[y + 1, x] == '╝' || map[y + 1, x] == '╚' || map[y + 1, x] == '█')
                    {
                        y++;
                        userMoves++;

                    }

                }
                else if (userMove == 'a' && x > 0 && map[y, x - 1] != '.')
                {
                    if (map[y, x - 1] == '╬' || map[y, x - 1] == '═' || map[y, x - 1] == '╦' || map[y, x - 1] == '╩' || map[y, x - 1] == '╠' || map[y, x - 1] == '╚' || map[y, x - 1] == '╔' || map[y, x - 1] == '█')
                    {
                        x--;
                        userMoves++;

                    }
                }
                else if (userMove == 'd' && x != xmax && map[y, x + 1] != '.')
                {
                    if (map[y, x + 1] == '╬' || map[y, x + 1] == '═' || map[y, x + 1] == '╦' || map[y, x + 1] == '╩' || map[y, x + 1] == '╣' || map[y, x + 1] == '╗' || map[y, x + 1] == '╝' || map[y, x + 1] == '█')
                    {
                        x++;
                        userMoves++;
                    }
                }
                else if (userMove == 'q')
                {
                    break;
                }
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                if (map[y, x] == '█')
                {
                    roomReached = true;
                }
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int k = 0; k < map.GetLength(1); k++)
                    {
                        Console.Write(map[i, k]);
                    }
                    Console.WriteLine("");
                }
                if (roomReached)
                {
                    if (userlanguage == '1')
                    {
                        Console.WriteLine("Kincs megtalálva!");
                    }
                    else if (userlanguage == '2')
                    {
                        Console.WriteLine("Treasure found!");
                    }
                }
                if (userlanguage == '1')
                {

                    Console.WriteLine("Lépések száma: "+userMoves.ToString());
                }
                else if (userlanguage == '2')
                {
                    Console.WriteLine("Moves so far: "+userMoves.ToString());
                }
                Console.SetCursorPosition(x, y);
                if (map[y, x] == '═' && x == 0 || map[y, x] == '═' && x == xmax - 1 || map[y, x] == '║' && y == 0 || map[y, x] == '║' && y == ymax - 1)
                {
                    canEscape = true;
                }
                else
                {
                    canEscape = false;
                }
                if (canEscape && roomReached)
                {
                    Console.Clear();
                    if (userlanguage == '1')
                    {
                        Console.WriteLine("Nyertél!");
                        Console.WriteLine(userMoves.ToString()+" lépésekből nyertél!");
                    }
                    else if (userlanguage == '2')
                    {
                        Console.WriteLine("Treasure found!");
                        Console.WriteLine("You moved "+userMoves.ToString()+" times");
                    }

                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
