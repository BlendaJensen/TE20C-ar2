using System;

namespace Lucktext
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Detta är ett program där du skriver in namn och ålder på en karaktär. Du skriver även in en plats.");

            Console.Write("Skriv in karaktärens namn: ");
            string namn = Console.ReadLine();

            Console.Write("Skriv in karaktärens ålder: ");
            string ålder = Console.ReadLine();

            Console.Write("Skriv in en plats: ");
            string plats = Console.ReadLine();

            Console.WriteLine($"{namn} var {ålder} år. {namn} var ute för att gå till {plats} och på vägen hände det något. ");
        }
    }
}
