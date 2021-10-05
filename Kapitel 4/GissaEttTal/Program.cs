using System;

namespace GissaEttTal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Spel - gissa ett tal mellan 1 och 100");

            //spela flera gånger
            while (true)
            {
                //Slumpa fram ett tal
                Random tärning = new Random();
                int slumptal = tärning.Next(1, 101);
                
                //Upprepa frågan 
                int räknare = 0;
                while (true)
                {
                    //Räkna antal varv
                    räknare++;
                    //fråga användaren om gissning
                    Console.Write("Gissa ett tal (1-100): ");
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
            Console.WriteLine("Nu får du göra ett till försök");
            }        

        }
    }
}
