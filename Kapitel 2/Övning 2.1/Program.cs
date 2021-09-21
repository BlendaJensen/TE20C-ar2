using System;

namespace Övning_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej, i vilken stad bor du?");
            string stad = Console.ReadLine();

            Console.WriteLine("Vad är ditt drömresemål?");
            string resemål = Console.ReadLine();

            Console.WriteLine($"Hej du från {stad}. Hoppas att du åker till {resemål}");
        }
    }
}
