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
                        LaunchGame("map.txt");
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
                            LaunchGame(filePath);
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

        static void LaunchGame(string filePath)
        {
            char[,] map;
            string[] lines = File.ReadAllLines(filePath);
            map = new char[lines.Count(), lines[0].Count()];
            for (int i = 0; i < lines.Count(); i++)
            {
                for (int k = 0; k < lines[0].Count(); k++)
                {
                    map[i, k] = lines[i][k];
                }
            }
            while (true)
            {

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
                Console.SetCursorPosition(x, y);
                while (true)
                {
                    char userMove = Console.ReadKey().KeyChar;
                    if (userMove == 'w' && y > 0)
                    {
                        y--;
                    }
                    else if (userMove == 's' && y + 1 < ymax)
                    {
                        y++;
                    }
                    else if (userMove == 'a' && x > 0)
                    {
                        x--;
                    }
                    else if (userMove == 'd' && x != xmax)
                    {
                        x++;
                    }
                    else if (userMove == 'q')
                    {
                        break;
                    }
                    Console.Clear();
                    for (int i = 0; i < map.GetLength(0); i++)
                    {
                        for (int k = 0; k < map.GetLength(1); k++)
                        {
                            Console.Write(map[i, k]);
                        }
                        Console.WriteLine("");
                    }
                    Console.SetCursorPosition(x, y);
                }
            }

        }
    }
}
