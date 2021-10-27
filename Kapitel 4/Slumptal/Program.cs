using System;

namespace Slumptal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Slumpgenerator
            Random generator = new Random();

            //Slumpa fram ett tal  ett till tio
            int Slumptal = generator.Next(1,11);

            int Slumptal2 = generator.Next(1,7);

            Console.WriteLine($"{Slumptal} {Slumptal2}");
        }
    }
}
