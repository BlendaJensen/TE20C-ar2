using System;

namespace GissaEttTal2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Spelet Gissa ett tal");

            // slumpa fram ett tal
            Random tärning = new Random();
            int slumptal = tärning.Next(1, 51);

            // Loopa 5 gånger
            int räknare = 0;
            while (true)
            {
                //räkna varv
                räknare++;

                //bryt efter 5 varv
                if (räknare >= 6)
                {
                    break;
                }
                //fråga användaren om gissning
                Console.Write("Gissa ett tal (1-50): ");
                int gissning = int.Parse(Console.ReadLine());

                //är gissningen rätt
                if (gissning == slumptal)
                {
                    Console.WriteLine($"Rätt! Du gjorde det på {räknare} försök");
                    break;
                }

                //jämför med slumptal
                if (gissning < slumptal)
                {
                    Console.WriteLine("För lågt");
                }
                else
                {
                    Console.WriteLine("För högt");
                }                
            }
        }
    }
}
