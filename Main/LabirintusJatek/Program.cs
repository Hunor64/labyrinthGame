using System;

namespace LabirintusJatek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int language = 1;
            Console.Write("Válasszon nyelvet! / Choose a Language:\n1. Magyar\n2.English");
            language = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                int choise = 0;
                if (language == 1)
                {
                    Console.WriteLine("1. Játék gyors folytatása");
                    Console.WriteLine("2. Új pálya");
                    Console.WriteLine("3. Pálya betöltése");
                    Console.WriteLine("4. Pályaszerkeztő megnyitása");
                    Console.WriteLine("5. Nyelv változtatása / Change language");
                    Console.WriteLine("6. Kilépés");

                }
                if (language == 2)
                {
                    Console.WriteLine("1. Quick resume game");
                    Console.WriteLine("2. New game");
                    Console.WriteLine("3. Load game");
                    Console.WriteLine("4. Open map editor");
                    Console.WriteLine("5. Nyelv változtatása / Change language");
                    Console.WriteLine("6. Quit game");
                }
            }
        }
    }
}
