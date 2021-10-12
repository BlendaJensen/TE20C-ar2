using System;

namespace Uppgift_4._19
{
    class Program
    {
        static void Main(string[] args)
        {
            //ställer frågan
            Console.WriteLine("Vilket land är världens folkrikaste land?");
            string svar = Console.ReadLine();

            //Medan svaret är ej lika med Kina
            while (svar != "Kina")
            {
                Console.WriteLine("Fel svar, försök igen");
                svar = Console.ReadLine();
            }

            Console.WriteLine("Du svarade rätt! Grattis");
        }
    }
}
