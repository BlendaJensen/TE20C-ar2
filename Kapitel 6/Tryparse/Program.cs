using System;

namespace Tryparse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gissa ett tal");

            //Slumpgenerator
            Random generator = new Random();

            //Slumpa fram ett tal mellan 1 o hundra
            int slumptal = generator.Next(1, 101);
            int slumptal2 = generator.Next(1, 11);

            //Försök att översätta det inmatade till tal
            int gissningtal = 0;
            bool korrekt = false;

            //loop för att tvinga spelaren att mata in något korrekt
            while (korrekt != true)
            {
                Console.Write("Gissa ett tal (1-100): ");
                string gissning = Console.ReadLine();
                korrekt = int.TryParse(gissning, out gissningtal);
            }
            
            //Var gissningen korrekt
            if (gissningtal == slumptal)
            {
                Console.WriteLine("Du gissade rätt");
            }
            else 
            {
                Console.WriteLine("Fel");
            }
        }
    }
}
