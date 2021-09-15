using System;

namespace Övning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Detta program frågar vad du heter och bor");

            Console.Write("Vad heter du? ");

            string namn = Console.ReadLine();

            Console.WriteLine("Hej på dig" + namn);

            Console.Write("Vart bor du? ");
            string ort = Console.ReadLine();
            Console.WriteLine("Vad trevligt att bo i " + ort);

            Console.WriteLine("Hur gammal är du? ");
            string ålder = Console.ReadLine();
            Console.WriteLine("Du är ålder gammal");
        }
    }
}
