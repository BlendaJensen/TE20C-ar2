using System;

namespace Mening
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange en mening: ");
            string mening = Console.ReadLine();
            
            //Dela upp ord för ord
            //Split = sax
            string[] orden = mening.Split(' ');

            // Skriv ut alla ord på var sin rad2
            foreach (var ord in orden)
            { 
                Console.WriteLine(ord);
            }
            //Säger hur många ord som finns
            Console.WriteLine($"Det finns {orden.Length} ord i meningen");

            //Sätt samman en ny mening
            string nymening = string.Join('/', orden);
            //skriv mening
            Console.WriteLine(nymening);
        }
    }
}
