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
            Console.Write("");
        }
    }
}
